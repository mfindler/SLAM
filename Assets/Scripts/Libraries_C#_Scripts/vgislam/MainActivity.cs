using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;

namespace com.example.vgislam
{

    using Builder = android.app.AlertDialog.Builder;
    using DialogInterface = android.content.DialogInterface;
    using OnClickListener = android.content.DialogInterface.OnClickListener;
    using UsbDevice = android.hardware.usb.UsbDevice;
    using UsbDeviceConnection = android.hardware.usb.UsbDeviceConnection;
    using Bundle = android.os.Bundle;
    using Environment = android.os.Environment;
    using Log = android.util.Log;
    using UnityPlayerActivity = com.unity3d.player.UnityPlayerActivity;
    using Context = org.openni.Context;
    using DepthGenerator = org.openni.DepthGenerator;
    using DepthMap = org.openni.DepthMap;
    using GeneralException = org.openni.GeneralException;
    using MirrorCapability = org.openni.MirrorCapability;
    using NodeType = org.openni.NodeType;
    using OutArg = org.openni.OutArg;
    using ScriptNode = org.openni.ScriptNode;
    using StatusException = org.openni.StatusException;
    using OpenNIHelper = org.openni.android.OpenNIHelper;
    using DevicePermissionListener = org.openni.android.OpenNIHelper.DevicePermissionListener;
    using OpenNIView = org.openni.android.OpenNIView;
    using System.IO;
    public class MainActivity : UnityPlayerActivity, OpenNIHelper.DevicePermissionListener
	{
		private bool InstanceFieldsInitialized = false;

		public MainActivity()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}
		}

		private void InitializeInstanceFields()
		{
			rawDepth = new short[this.width * this.height];
		}

	  private const string TAG = "NewLargeScale";
	  private OpenNIView mDepthView;
	  private OpenNIView mImageView;
	  private UsbDeviceConnection mDeviceConnection;
	  private OpenNIHelper mOpenNIHelper;
	  private Thread mMainLoopThread;
	  private bool mShouldRun = true;
	  private bool mDevicePermissionPending = false;
	  private OutArg<ScriptNode> mScriptNode;
	  private Context mOpenNIContext;
	  public const string SAMPLE_XML_FILE = "SamplesConfig.xml";
	  private bool mHaveImageNode;
	  private DepthGenerator mDepthGenerator;
	  private DepthMap mDepthMap;
	  private int width = 160;
	  private int height = 120;
	  private bool bSetRes = false;
	  private int SCAN_MIN_X = -40;
	  private int SCAN_MAX_X = 40;
	  private int SCAN_MIN_Y = -40;
	  private int SCAN_MAX_Y = 40;
	  private int SCAN_MIN_Z = 500;
	  private int SCAN_MAX_Z = 1300;
	  private int EDGE_SIZE = 100;
	  private short[] rawDepth;
	  private bool slamStatus = false;
	  private bool bFirstScan = true;
	  private bool bStart = false;
	  private string outPath = Environment.ExternalStorageDirectory.Path + "/VGIOUT";
	  private string outFile = Environment.ExternalStorageDirectory.Path + "/VGIOUT/GlobalMesh.obj";
	  private int nTriangles = 0;

	  protected internal virtual void onCreate(Bundle savedInstanceState)
	  {
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("VGISLAM");

		File outDir = new File(outPath);
		if (!outDir.exists())
		{
		  outDir.mkdir();
		}
		this.mOpenNIHelper = new OpenNIHelper(this);

		base.onCreate(savedInstanceState);
	  }

	  protected internal virtual void onDestroy()
	  {
		base.onDestroy();

		this.mOpenNIHelper.shutdown();
	  }

	  protected internal virtual void onResume()
	  {
		Log.d("NewLargeScale", "onResume");

		base.onResume();
		if (this.mDevicePermissionPending)
		{
		  return;
		}
		Dictionary<string, UsbDevice> deviceList = this.mOpenNIHelper.DeviceList;
		if (deviceList.Count == 0)
		{
		  showNoDeviceAlert();
		  return;
		}
		this.mDevicePermissionPending = true;
		this.mOpenNIHelper.requestDevicePermission((UsbDevice)deviceList.Values.ToArray()[0], this);
	  }

	  private void showNoDeviceAlert()
	  {
		AlertDialog.Builder builder = new AlertDialog.Builder(this);
		builder.Message = "No OpenNI-compliant device found.";
		builder.setNeutralButton("OK", new OnClickListenerAnonymousInnerClassHelper(this));
		builder.show();
	  }

	  private class OnClickListenerAnonymousInnerClassHelper : DialogInterface.OnClickListener
	  {
		  private readonly MainActivity outerInstance;

		  public OnClickListenerAnonymousInnerClassHelper(MainActivity outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  public virtual void onClick(DialogInterface dialog, int which)
		  {
			outerInstance.finish();
		  }
	  }

	  public virtual void onDevicePermissionGranted(UsbDevice device)
	  {
		Log.d("NewLargeScale", "Permission granted for device " + device);

		this.mDevicePermissionPending = false;

		this.mDeviceConnection = this.mOpenNIHelper.openDevice(device);

		this.mScriptNode = new OutArg();
		try
		{
		  this.mOpenNIContext = Context.createFromXmlFile(XmlFilePath, this.mScriptNode);

		  this.mDepthGenerator = DepthGenerator.create(this.mOpenNIContext);

		  this.mDepthGenerator.startGenerating();
		}
		catch (GeneralException e)
		{
		  Log.e("NewLargeScale", "Failed to create context");
		}
		try
		{
		  this.mHaveImageNode = (this.mOpenNIContext.findExistingNode(NodeType.IMAGE) != null);
		}
		catch (GeneralException)
		{
		  this.mHaveImageNode = false;
		}
		try
		{
		  MirrorCapability mDepthMirror = new MirrorCapability(this.mDepthGenerator);
		  mDepthMirror.Mirror = false;
		}
		catch (StatusException emirr)
		{
		  Console.WriteLine(emirr.ToString());
		  Console.Write(emirr.StackTrace);
		}
		this.mShouldRun = true;
		this.mMainLoopThread = new ThreadAnonymousInnerClassHelper(this, e);
		this.mMainLoopThread.Name = "OpenNI MainLoop Thread";
		this.mMainLoopThread.Start();
	  }

	  private class ThreadAnonymousInnerClassHelper : System.Threading.Thread
	  {
		  private readonly MainActivity outerInstance;

		  private GeneralException e;

		  public ThreadAnonymousInnerClassHelper(MainActivity outerInstance, GeneralException e)
		  {
			  this.outerInstance = outerInstance;
			  this.e = e;
		  }

		  public virtual void run()
		  {
			while (outerInstance.mShouldRun)
			{
			  try
			  {
				outerInstance.mOpenNIContext.waitAnyUpdateAll();
			  }
			  catch (StatusException e)
			  {
				Log.e("NewLargeScale", "Failed updating context.");
			  }
			}
		  }
	  }

	  public virtual void onDevicePermissionDenied(UsbDevice device)
	  {
		Log.e("NewLargeScale", "Permission denied for device " + device);

		this.mDevicePermissionPending = false;
	  }

	  protected internal virtual void onPause()
	  {
		Log.d("NewLargeScale", "onPause");

		base.onPause();
		if (this.mDevicePermissionPending)
		{
		  return;
		}
		this.mShouldRun = false;
		while (this.mMainLoopThread != null)
		{
		  try
		  {
			this.mMainLoopThread.Join();
			this.mMainLoopThread = null;
		  }
		  catch (InterruptedException)
		  {
		  }
		}
		if (this.mDepthView != null)
		{
		  this.mDepthView.OpenNIContext = null;
		}
		if (this.mImageView != null)
		{
		  this.mImageView.OpenNIContext = null;
		}
		if (this.mScriptNode != null)
		{
		  ((ScriptNode)this.mScriptNode.value).dispose();
		  this.mScriptNode = null;
		}
		if (this.mOpenNIContext != null)
		{
		  this.mOpenNIContext.dispose();
		  this.mOpenNIContext = null;
		}
		if (this.mDeviceConnection != null)
		{
		  this.mDeviceConnection.close();
		  this.mDeviceConnection = null;
		}
		if (this.mDepthGenerator != null)
		{
		  this.mDepthGenerator.dispose();
		  this.mDepthGenerator = null;
		}
		if (this.rawDepth != null)
		{
		  this.rawDepth = null;
		}
	  }

	  public virtual void InitializeSLAM()
	  {
		this.bFirstScan = true;
		initmodel();
	  }

	  public virtual bool StartSLAM()
	  {
		short[] srcScans = new short[this.width * this.height];
		int numOfEffectivePts = 0;
		try
		{
		  this.mDepthMap = this.mDepthGenerator.DepthMap;
		}
		catch (GeneralException em)
		{
		  Console.WriteLine(em.ToString());
		  Console.Write(em.StackTrace);
		}
		for (int ny = 0; ny < this.height; ny++)
		{
		  for (int nx = 0; nx < this.width; nx++)
		  {
			srcScans[(this.width * ny + nx)] = 0;

			short rawD = this.mDepthMap.readPixel(nx, ny);
			if ((rawD >= this.SCAN_MIN_Z - this.EDGE_SIZE) && (rawD < this.SCAN_MAX_Z + this.EDGE_SIZE))
			{
			  srcScans[(this.width * ny + nx)] = rawD;

			  numOfEffectivePts++;
			}
		  }
		}
		this.slamStatus = false;
		if (numOfEffectivePts > 200)
		{
		  this.slamStatus = slamrtmesh(srcScans, this.bFirstScan);
		  if (this.bFirstScan)
		  {
			this.bFirstScan = false;
		  }
		}
		srcScans = null;

		return this.slamStatus;
	  }

	  public virtual string MeshFilePath()
	  {
		return this.outFile;
	  }

	  public virtual float[] CamPos()
	  {
		float[] tranData = new float[3];
		for (int i = 0; i < 3; i++)
		{
		  tranData[i] = 0.0F;
		}
		cameraposition(tranData);

		return tranData;
	  }

	  public virtual void StopSLAM()
	  {
		meshobj(this.outFile);
	  }

	  public virtual float[] GlobalPTS()
	  {
		float[] glpts = new float[3000000];
		readglpts(glpts);

		int nGL = 0;
		for (int n = 0; n < 1000000; n++)
		{
		  if ((glpts[(3 * n)] != 0.0F) && (glpts[(3 * n + 1)] != 0.0F) && (glpts[(3 * n + 2)] != 0.0F))
		  {
			nGL++;
		  }
		}
		float[] retpts = new float[nGL * 3];

		nGL = 0;
		for (int n = 0; n < 1000000; n++)
		{
		  if ((glpts[(3 * n)] != 0.0F) && (glpts[(3 * n + 1)] != 0.0F) && (glpts[(3 * n + 2)] != 0.0F))
		  {
			retpts[(3 * nGL)] = glpts[(3 * n)];
			retpts[(3 * nGL + 1)] = glpts[(3 * n + 1)];
			retpts[(3 * nGL + 2)] = glpts[(3 * n + 2)];
			nGL++;
		  }
		}
		glpts = null;
		return retpts;
	  }

	  public virtual float[] SourcePTS()
	  {
		float[] srcpts = new float[this.width * this.height * 3];
		readsrcpts(srcpts);
		int nSrc = 0;
		for (int n = 0; n < this.width * this.height; n++)
		{
		  if ((srcpts[(3 * n)] != 0.0F) && (srcpts[(3 * n + 1)] != 0.0F) && (srcpts[(3 * n + 2)] != 0.0F))
		  {
			nSrc++;
		  }
		}
		float[] retpts = new float[nSrc * 3];

		nSrc = 0;
		for (int n = 0; n < this.width * this.height; n++)
		{
		  if ((srcpts[(3 * n)] != 0.0F) && (srcpts[(3 * n + 1)] != 0.0F) && (srcpts[(3 * n + 2)] != 0.0F))
		  {
			retpts[(3 * nSrc)] = srcpts[(3 * n)];
			retpts[(3 * nSrc + 1)] = srcpts[(3 * n + 1)];
			retpts[(3 * nSrc + 2)] = srcpts[(3 * n + 2)];
			nSrc++;
		  }
		}
		srcpts = null;
		return retpts;
	  }

	  public virtual string XmlFilePath
	  {
		  get
		  {
			File externalConfigFile = new File(Environment.ExternalStorageDirectory, "SamplesConfig.xml");
			if (externalConfigFile.exists())
			{
			  return externalConfigFile.Path;
			}
			return FilesDir + "/" + "SamplesConfig.xml";
		  }
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern void initmodel();

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern boolean slamrtmesh(short[] paramArrayOfShort, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern boolean slamrtpts(float[] paramArrayOfFloat, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern void cameraposition(float[] paramArrayOfFloat);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern void meshobj(string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern void readglpts(float[] paramArrayOfFloat);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  public extern void readsrcpts(float[] paramArrayOfFloat);
	}

}