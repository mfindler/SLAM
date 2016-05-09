namespace org.openni
{

	public class NodeInfo : ObjectWrapper
	{
	  public virtual ProductionNodeDescription Description
	  {
		  get
		  {
			return NativeMethods.xnNodeInfoGetDescription(toNative());
		  }
	  }

	  public virtual string InstanceName
	  {
		  get
		  {
			return NativeMethods.xnNodeInfoGetInstanceName(toNative());
		  }
	  }

	  public virtual string CreationInfo
	  {
		  get
		  {
			return NativeMethods.xnNodeInfoGetCreationInfo(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfoList getNeededNodes() throws GeneralException
	  public virtual NodeInfoList NeededNodes
	  {
		  get
		  {
			return new NodeInfoList(NativeMethods.xnNodeInfoGetNeededNodes(toNative()), false);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ProductionNode getInstance() throws GeneralException
	  public virtual ProductionNode Instance
	  {
		  get
		  {
			long l = NativeMethods.xnNodeInfoGetRefHandle(toNative());
			return Context.createProductionNodeFromNative(l);
		  }
	  }

	  public override string ToString()
	  {
		OutArg localOutArg = new OutArg();
		NativeMethods.xnNodeInfoGetTreeStringRepresentation(toNative(), localOutArg);
		return (string)localOutArg.value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected NodeInfo(long paramLong) throws GeneralException
	  protected internal NodeInfo(long paramLong) : base(paramLong)
	  {
	  }

	  protected internal virtual void freeObject(long paramLong)
	  {
	  }
	}

}