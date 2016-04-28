namespace org.openni
{

	public class UserEventArgs : EventArgs
	{
	  private readonly int id;

	  public UserEventArgs(int paramInt)
	  {
		this.id = paramInt;
	  }

	  public virtual int Id
	  {
		  get
		  {
			return this.id;
		  }
	  }
	}

}