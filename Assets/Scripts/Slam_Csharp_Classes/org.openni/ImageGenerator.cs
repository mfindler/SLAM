namespace org.openni
{

	public class ImageGenerator : MapGenerator
	{
	  private ImageMap currImageMap;
	  private int currImageMapFrameID;
	  private StateChangedObservable pixelFormatChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: ImageGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal ImageGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.pixelFormatChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly ImageGenerator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(ImageGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToPixelFormatChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromPixelFormatChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static ImageGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static ImageGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateImageGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		ImageGenerator localImageGenerator = (ImageGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.IMAGE);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localImageGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static ImageGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static ImageGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static ImageGenerator create(Context paramContext) throws GeneralException
	  public static ImageGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

	  public virtual bool isPixelFormatSupported(PixelFormat paramPixelFormat)
	  {
		return NativeMethods.xnIsPixelFormatSupported(toNative(), paramPixelFormat.toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setPixelFormat(PixelFormat paramPixelFormat) throws StatusException
	  public virtual PixelFormat PixelFormat
	  {
		  set
		  {
			int i = NativeMethods.xnSetPixelFormat(toNative(), value.toNative());
			WrapperUtils.throwOnError(i);
		  }
		  get
		  {
			return PixelFormat.fromNative(NativeMethods.xnGetPixelFormat(toNative()));
		  }
	  }


//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ImageMap getImageMap() throws GeneralException
	  public virtual ImageMap ImageMap
	  {
		  get
		  {
			int i = FrameID;
			if ((this.currImageMap == null) || (this.currImageMapFrameID != i))
			{
			  long l = NativeMethods.xnGetImageMap(toNative());
			  MapOutputMode localMapOutputMode = MapOutputMode;
			  this.currImageMap = new ImageMap(l, localMapOutputMode.XRes, localMapOutputMode.YRes, NativeMethods.xnGetBytesPerPixel(toNative()));
			  this.currImageMapFrameID = i;
			}
			return this.currImageMap;
		  }
	  }

	  public virtual IStateChangedObservable PixelFormatChangedEvent
	  {
		  get
		  {
			return this.pixelFormatChanged;
		  }
	  }

	  public virtual void getMetaData(ImageMetaData paramImageMetaData)
	  {
		NativeMethods.xnGetImageMetaData(toNative(), paramImageMetaData);
	  }

	  public virtual ImageMetaData MetaData
	  {
		  get
		  {
			ImageMetaData localImageMetaData = new ImageMetaData();
			getMetaData(localImageMetaData);
			return localImageMetaData;
		  }
	  }
	}

}