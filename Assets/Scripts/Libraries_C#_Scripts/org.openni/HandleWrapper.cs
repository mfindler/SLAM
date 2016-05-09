namespace org.openni
{

	public class HandleWrapper
	{
	  private int handle;

	  public HandleWrapper(int paramInt)
	  {
		this.handle = paramInt;
	  }

	  public virtual int toNative()
	  {
		return this.handle;
	  }
	}

}