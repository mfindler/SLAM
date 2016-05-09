namespace org.openni
{

	public abstract class ObjectWrapper
	{
	  private long ptr;

	  public ObjectWrapper(long paramLong)
	  {
		if (paramLong == 0L)
		{
		  throw new System.NullReferenceException("JavaWrapper: Trying to wrap a null object!");
		}
		this.ptr = paramLong;
	  }

	  public virtual long toNative()
	  {
		return this.ptr;
	  }

	  ~ObjectWrapper()
	  {
		dispose();
	  }

	  public virtual void dispose()
	  {
		if (this.ptr != 0L)
		{
		  freeObject(this.ptr);
		  this.ptr = 0L;
		}
	  }

	  protected internal abstract void freeObject(long paramLong);
	}

}