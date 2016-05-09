namespace org.openni
{

	public class IRGenerator : MapGenerator
	{
	  private IRMap currIRMap;
	  private int currIRMapFrameID;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: IRGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal IRGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static IRGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static IRGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateIRGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		IRGenerator localIRGenerator = (IRGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.IR);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localIRGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static IRGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static IRGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static IRGenerator create(Context paramContext) throws GeneralException
	  public static IRGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public IRMap getIRMap() throws GeneralException
	  public virtual IRMap IRMap
	  {
		  get
		  {
			int i = FrameID;
			if ((this.currIRMap == null) || (this.currIRMapFrameID != i))
			{
			  long l = NativeMethods.xnGetIRMap(toNative());
			  MapOutputMode localMapOutputMode = MapOutputMode;
			  this.currIRMap = new IRMap(l, localMapOutputMode.XRes, localMapOutputMode.YRes);
			  this.currIRMapFrameID = i;
			}
			return this.currIRMap;
		  }
	  }

	  public virtual void getMetaData(IRMetaData paramIRMetaData)
	  {
		NativeMethods.xnGetIRMetaData(toNative(), paramIRMetaData);
	  }

	  public virtual IRMetaData MetaData
	  {
		  get
		  {
			IRMetaData localIRMetaData = new IRMetaData();
			getMetaData(localIRMetaData);
			return localIRMetaData;
		  }
	  }
	}

}