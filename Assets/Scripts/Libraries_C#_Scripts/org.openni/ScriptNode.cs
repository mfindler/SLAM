namespace org.openni
{

	public class ScriptNode : ProductionNode
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: ScriptNode(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  internal ScriptNode(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static ScriptNode create(Context paramContext, String paramString) throws GeneralException
	  public static ScriptNode create(Context paramContext, string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateScriptNode(paramContext.toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		ScriptNode localScriptNode = (ScriptNode)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.SCRIPT_NODE);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localScriptNode;
	  }

	  public virtual string SupportedFormat
	  {
		  get
		  {
			return NativeMethods.xnScriptNodeGetSupportedFormat(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void loadScriptFromFile(String paramString) throws StatusException
	  public virtual void loadScriptFromFile(string paramString)
	  {
		int i = NativeMethods.xnLoadScriptFromFile(toNative(), paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void loadScriptFromString(String paramString) throws StatusException
	  public virtual void loadScriptFromString(string paramString)
	  {
		int i = NativeMethods.xnLoadScriptFromString(toNative(), paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void Run(EnumerationErrors paramEnumerationErrors) throws StatusException
	  public virtual void Run(EnumerationErrors paramEnumerationErrors)
	  {
		int i = NativeMethods.xnScriptNodeRun(toNative(), paramEnumerationErrors.toNative());
		WrapperUtils.throwOnError(i);
	  }
	}

}