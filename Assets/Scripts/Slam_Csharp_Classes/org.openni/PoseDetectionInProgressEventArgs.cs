namespace org.openni
{

	public class PoseDetectionInProgressEventArgs : EventArgs
	{
	  private readonly string pose;
	  private readonly int user;
	  private readonly PoseDetectionStatus status;

	  public PoseDetectionInProgressEventArgs(string paramString, int paramInt, PoseDetectionStatus paramPoseDetectionStatus)
	  {
		this.pose = paramString;
		this.user = paramInt;
		this.status = paramPoseDetectionStatus;
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

	  public virtual PoseDetectionStatus Status
	  {
		  get
		  {
			return this.status;
		  }
	  }
	}

}