namespace org.openni
{

	public class DeviceIdentificationCapability : CapabilityBase
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public DeviceIdentificationCapability(ProductionNode paramProductionNode) throws StatusException
	  public DeviceIdentificationCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getDeviceName() throws StatusException
	  public virtual string DeviceName
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetDeviceName(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
			return (string)localOutArg.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getVendorSpecificData() throws StatusException
	  public virtual string VendorSpecificData
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetVendorSpecificData(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
			return (string)localOutArg.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getSerialNumber() throws StatusException
	  public virtual string SerialNumber
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetSerialNumber(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
			return (string)localOutArg.value;
		  }
	  }
	}

}