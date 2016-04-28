namespace org.openni
{

	public class Device : ProductionNode
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Device(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  public Device(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Device create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static Device create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateDevice(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		Device localDevice = (Device)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.DEVICE);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localDevice;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Device create(Context paramContext, Query paramQuery) throws GeneralException
	  public static Device create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Device create(Context paramContext) throws GeneralException
	  public static Device create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public DeviceIdentificationCapability getDeviceIdentificationCapability() throws StatusException
	  public virtual DeviceIdentificationCapability DeviceIdentificationCapability
	  {
		  get
		  {
			return new DeviceIdentificationCapability(this);
		  }
	  }
	}

}