using System;
using System.Collections.Generic;

namespace org.openni.android
{

	using PendingIntent = android.app.PendingIntent;
	using BroadcastReceiver = android.content.BroadcastReceiver;
	using Context = android.content.Context;
	using Intent = android.content.Intent;
	using IntentFilter = android.content.IntentFilter;
	using AssetManager = android.content.res.AssetManager;
	using UsbDevice = android.hardware.usb.UsbDevice;
	using UsbDeviceConnection = android.hardware.usb.UsbDeviceConnection;
	using UsbManager = android.hardware.usb.UsbManager;
	using Log = android.util.Log;

	public class OpenNIHelper
	{
	  private Context mAndroidContext;
	  private const string OPENNI_ASSETS_DIR = "openni";
	  private string mActionUsbPermission;
	  private DevicePermissionListener mDevicePermissionListener;
	  private const string TAG = "OpenNINIHelper";

	  static OpenNIHelper()
	  {
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("usb");
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("OpenNI");
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("OpenNI.jni");
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("XnCore");
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("XnFormats");
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("XnDDK");
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		System.loadLibrary("OpenNIAndroid");
	  }

	  public OpenNIHelper(Context context)
	  {
		this.mAndroidContext = context;
		try
		{
		  string[] arrayOfString;
		  int j = (arrayOfString = this.mAndroidContext.Assets.list("openni")).Length;
		  for (int i = 0; i < j; i++)
		  {
			string fileName = arrayOfString[i];
			extractOpenNIAsset(fileName);
		  }
		}
		catch (IOException e)
		{
		  throw new Exception(e);
		}
		this.mActionUsbPermission = (context.PackageName + ".USB_PERMISSION");

		IntentFilter filter = new IntentFilter(this.mActionUsbPermission);
		this.mAndroidContext.registerReceiver(this.mUsbReceiver, filter);
	  }

	  public virtual void requestDevicePermission(UsbDevice device, DevicePermissionListener listener)
	  {
		PendingIntent permissionIntent = PendingIntent.getBroadcast(this.mAndroidContext, 0, new Intent(this.mActionUsbPermission), 0);

		this.mDevicePermissionListener = listener;

		UsbManager manager = (UsbManager)this.mAndroidContext.getSystemService("usb");

		manager.requestPermission(device, permissionIntent);
	  }

	  public virtual Dictionary<string, UsbDevice> DeviceList
	  {
		  get
		  {
			UsbManager manager = (UsbManager)this.mAndroidContext.getSystemService("usb");
			Dictionary<string, UsbDevice> deviceList = manager.DeviceList;
			IEnumerator<UsbDevice> iterator = deviceList.Values.GetEnumerator();
			while (iterator.MoveNext())
			{
			  UsbDevice device = (UsbDevice)iterator.Current;
			  int vendorId = device.VendorId;
			  int productId = device.ProductId;
    
			  Log.i("OpenNINIHelper", "Found USB device; vid=0x" + vendorId.ToString("x") + " pid=0x" + productId.ToString("x"));
			  if ((vendorId != 7463) || ((productId != 1536) && (productId != 1537) && (productId != 4688)))
			  {
	//JAVA TO C# CONVERTER TODO TASK: .NET enumerators are read-only:
				iterator.remove();
			  }
			}
			return deviceList;
		  }
	  }

	  public virtual UsbDeviceConnection openDevice(UsbDevice device)
	  {
		return ((UsbManager)this.mAndroidContext.getSystemService("usb")).openDevice(device);
	  }

	  public virtual void shutdown()
	  {
		this.mAndroidContext.unregisterReceiver(this.mUsbReceiver);
	  }

	  private readonly BroadcastReceiver mUsbReceiver = new BroadcastReceiverAnonymousInnerClassHelper();

	  private class BroadcastReceiverAnonymousInnerClassHelper : BroadcastReceiver
	  {
		  public BroadcastReceiverAnonymousInnerClassHelper()
		  {
		  }

		  public virtual void onReceive(Context context, Intent intent)
		  {
			string action = intent.Action;
			if (outerInstance.mActionUsbPermission.Equals(action))
			{
			  lock (this)
			  {
				if (outerInstance.mDevicePermissionListener == null)
				{
				  return;
				}
				UsbDevice device = (UsbDevice)intent.getParcelableExtra("device");
				if (device == null)
				{
				  return;
				}
				if (intent.getBooleanExtra("permission", false))
				{
				  outerInstance.mDevicePermissionListener.onDevicePermissionGranted(device);
				}
				else
				{
				  outerInstance.mDevicePermissionListener.onDevicePermissionDenied(device);
				}
			  }
			}
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private void extractOpenNIAsset(String filename) throws java.io.IOException
	  private void extractOpenNIAsset(string filename)
	  {
		System.IO.Stream @is = this.mAndroidContext.Assets.open("openni/" + filename);

		this.mAndroidContext.deleteFile(filename);
		System.IO.Stream os = this.mAndroidContext.openFileOutput(filename, 0);

		sbyte[] buffer = new sbyte[@is.available()];
		@is.Read(buffer, 0, buffer.Length);
		@is.Close();
		os.Write(buffer, 0, buffer.Length);
		os.Close();
	  }

	  public abstract interface DevicePermissionListener
	  {
		void onDevicePermissionGranted(UsbDevice paramUsbDevice);

		void onDevicePermissionDenied(UsbDevice paramUsbDevice);
	  }
	}

}