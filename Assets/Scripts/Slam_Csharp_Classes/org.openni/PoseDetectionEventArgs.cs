namespace org.openni
{

	public class PoseDetectionEventArgs : EventArgs
	{
	  private readonly string pose;
	  private readonly int user;

	  public PoseDetectionEventArgs(string paramString, int paramInt)
	  {
		this.pose = paramString;
		this.user = paramInt;
	  }

	  public virtual string Pose
	  {
		  get
		  {
			return this.pose;
		  }
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