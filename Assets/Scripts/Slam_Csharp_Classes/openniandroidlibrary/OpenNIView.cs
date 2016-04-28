using System;
using System.Runtime.InteropServices;

namespace org.openni.android
{

	using GLSurfaceView = android.opengl.GLSurfaceView;
	using Renderer = android.opengl.GLSurfaceView.Renderer;
	using AttributeSet = android.util.AttributeSet;

	public class OpenNIView : GLSurfaceView
	{
	  public const int DISPLAY_DEPTH = 0;
	  public const int DISPLAY_IMAGE = 1;
	  public const int DISPLAY_SCENE_AND_DEPTH = 2;
	  private GLSurfaceView.Renderer mRenderer;
	  private int mDisplayMode;
	  private org.openni.Context mOpenNIContext = null;
	  private long mNativePtr;

	  internal class Renderer : GLSurfaceView.Renderer
	  {
		  private readonly OpenNIView outerInstance;

		internal GLSurfaceView.Renderer(OpenNIView outerInstance)
		{
			this.outerInstance = outerInstance;
		}

		public virtual void onSurfaceCreated(GL10 gl, EGLConfig c)
		{
		  OpenNIView.nativeOnSurfaceCreated(outerInstance.mNativePtr);
		}

		public virtual void onSurfaceChanged(GL10 gl, int w, int h)
		{
		  OpenNIView.nativeOnSurfaceChanged(outerInstance.mNativePtr, w, h);
		}

		public virtual void onDrawFrame(GL10 gl)
		{
		  lock (outerInstance)
		  {
			if (outerInstance.mOpenNIContext != null)
			{
			  OpenNIView.nativeOnDrawFrame(outerInstance.mNativePtr);
			}
		  }
		}
	  }

	  public OpenNIView(android.content.Context context, AttributeSet attrs) : base(context, attrs)
	  {
		initOpenNIView();
	  }

	  public OpenNIView(android.content.Context context) : base(context)
	  {
		initOpenNIView();
	  }

	  private void initOpenNIView()
	  {
		this.mNativePtr = nativeCreate();

		this.mRenderer = new GLSurfaceView.Renderer();
		Renderer = this.mRenderer;
		RenderMode = 0;

		DisplayMode = 0;
	  }

	  public virtual int DisplayMode
	  {
		  set
		  {
			  lock (this)
			  {
				this.mDisplayMode = value;
            
				org.openni.Context boundContext = this.mOpenNIContext;
				if (boundContext != null)
				{
				  OpenNIContext = null;
				}
				switch (this.mDisplayMode)
				{
				case 0:
				  nativeSetDisplayMode(this.mNativePtr, false, true, false);
				  break;
				case 1:
				  nativeSetDisplayMode(this.mNativePtr, false, false, true);
				  break;
				case 2:
				  nativeSetDisplayMode(this.mNativePtr, true, true, false);
			  break;
				}
				if (boundContext != null)
				{
				  OpenNIContext = boundContext;
				}
			  }
		  }
		  get
		  {
			return this.mDisplayMode;
		  }
	  }


	  public virtual org.openni.Context OpenNIContext
	  {
		  set
		  {
			  lock (this)
			  {
				this.mOpenNIContext = value;
				if (value != null)
				{
				  nativeSetOpenNIContext(this.mNativePtr, this.mOpenNIContext.toNative());
				  requestLayout();
				  invalidate();
				}
				else
				{
				  nativeSetOpenNIContext(this.mNativePtr, 0L);
				}
			  }
		  }
	  }

	  protected internal virtual void onMeasure(int widthMeasureSpec, int heightMeasureSpec)
	  {
		int frameWidth = this.mOpenNIContext != null ? nativeGetFrameWidth(this.mNativePtr) : 0;
		int frameHeight = this.mOpenNIContext != null ? nativeGetFrameHeight(this.mNativePtr) : 0;
		int width = getDefaultSize(frameWidth, widthMeasureSpec);
		int height = getDefaultSize(frameHeight, heightMeasureSpec);
		if ((frameWidth > 0) && (frameHeight > 0))
		{
		  if (frameWidth * height > width * frameHeight)
		  {
			height = width * frameHeight / frameWidth;
		  }
		  else if (frameWidth * height < width * frameHeight)
		  {
			width = height * frameWidth / frameHeight;
		  }
		}
		setMeasuredDimension(width, height);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected void finalize() throws Throwable
	  ~OpenNIView()
	  {
		nativeDestroy(this.mNativePtr);
//JAVA TO C# CONVERTER NOTE: The base class finalizer method is automatically called in C#:
//		base.finalize();
	  }

	  public virtual int FrameWidth
	  {
		  get
		  {
			return nativeGetFrameWidth(this.mNativePtr);
		  }
	  }

	  public virtual int FrameHeight
	  {
		  get
		  {
			return nativeGetFrameHeight(this.mNativePtr);
		  }
	  }

	  public virtual void update()
	  {
		  lock (this)
		  {
			if (this.mOpenNIContext == null)
			{
			  throw new Exception("No context set.");
			}
			nativeReadFrame(this.mNativePtr);
			requestRender();
		  }
	  }

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern long nativeCreate();

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void nativeDestroy(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void nativeSetOpenNIContext(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void nativeSetDisplayMode(long paramLong, bool paramBoolean1, bool paramBoolean2, bool paramBoolean3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int nativeOnDrawFrame(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void nativeOnSurfaceCreated(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void nativeOnSurfaceChanged(long paramLong, int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int nativeGetFrameWidth(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern int nativeGetFrameHeight(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  private static extern void nativeReadFrame(long paramLong);
	}

}