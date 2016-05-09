namespace org.openni
{

	public class InactiveHandEventArgs : EventArgs
	{
	  private readonly int id;
	  private readonly float time;

	  public InactiveHandEventArgs(int paramInt, float paramFloat)
	  {
		this.id = paramInt;
		this.time = paramFloat;
	  }

	  public virtual int Id
	  {
		  get
		  {
			return this.id;
		  }
	  }

	  public virtual float Time
	  {
		  get
		  {
			return this.time;
		  }
	  }
	}

}