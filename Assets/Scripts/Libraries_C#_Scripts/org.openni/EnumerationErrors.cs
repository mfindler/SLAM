namespace org.openni
{

	public class EnumerationErrors : ObjectWrapper
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public EnumerationErrors() throws StatusException
	  public EnumerationErrors() : this(create())
	  {
	  }

	  public virtual bool Empty
	  {
		  get
		  {
			long l = NativeMethods.xnEnumerationErrorsGetFirst(toNative());
			return !NativeMethods.xnEnumerationErrorsIteratorIsValid(l);
		  }
	  }

	  public override string ToString()
	  {
		OutArg localOutArg = new OutArg();
		NativeMethods.xnEnumerationErrorsToString(toNative(), localOutArg);
		return (string)localOutArg.value;
	  }

	  protected internal virtual void freeObject(long paramLong)
	  {
		NativeMethods.xnEnumerationErrorsFree(paramLong);
	  }

	  private EnumerationErrors(long paramLong) : base(paramLong)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private static long create() throws StatusException
	  private static long create()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerationErrorsAllocate(localOutArg);
		WrapperUtils.throwOnError(i);
		return ((long?)localOutArg.value).Value;
	  }
	}

}