namespace org.openni
{

	public class CalibrationProgressEventArgs : EventArgs
	{
	  private readonly int user;
	  private readonly CalibrationProgressStatus state;

	  public CalibrationProgressEventArgs(int paramInt, CalibrationProgressStatus paramCalibrationProgressStatus)
	  {
		this.user = paramInt;
		this.state = paramCalibrationProgressStatus;
	  }

	  public virtual int User
	  {
		  get
		  {
			return this.user;
		  }
	  }

	  public virtual CalibrationProgressStatus Status
	  {
		  get
		  {
			return this.state;
		  }
	  }
	}

}