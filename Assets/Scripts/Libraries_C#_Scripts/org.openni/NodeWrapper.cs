namespace org.openni
{

	public class NodeWrapper : ObjectWrapper
	{
	  private Context context;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: NodeWrapper(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  internal NodeWrapper(Context paramContext, long paramLong, bool paramBoolean) : base(paramLong)
	  {

		this.context = paramContext;
		if (paramBoolean)
		{
		  WrapperUtils.throwOnError(NativeMethods.xnProductionNodeAddRef(paramLong));
		}
	  }

	  public virtual Context Context
	  {
		  get
		  {
			return this.context;
		  }
	  }

	  public virtual string Name
	  {
		  get
		  {
			return NativeMethods.xnGetNodeName(toNative());
		  }
	  }

	  protected internal virtual void freeObject(long paramLong)
	  {
		NativeMethods.xnProductionNodeRelease(paramLong);
	  }
	}

}