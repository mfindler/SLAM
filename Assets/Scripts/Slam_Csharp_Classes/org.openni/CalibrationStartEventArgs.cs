namespace org.openni
{

	public class CalibrationStartEventArgs : EventArgs
	{
	  private int user;

	  internal CalibrationStartEventArgs(int paramInt)
	  {
		this.user = paramInt;
	  }

	  public virtual int User
	  {
		  get
		  {
			return this.user;
		  }
	  }
	}

}