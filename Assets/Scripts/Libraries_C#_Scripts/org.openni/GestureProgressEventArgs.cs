namespace org.openni
{

	public class GestureProgressEventArgs : EventArgs
	{
	  private readonly string gesture;
	  private readonly Point3D position;
	  private readonly float progress;

	  public GestureProgressEventArgs(string paramString, Point3D paramPoint3D, float paramFloat)
	  {
		this.gesture = paramString;
		this.position = paramPoint3D;
		this.progress = paramFloat;
	  }

	  public virtual string Gesture
	  {
		  get
		  {
			return this.gesture;
		  }
	  }

	  public virtual Point3D Position
	  {
		  get
		  {
			return this.position;
		  }
	  }

	  public virtual float Progress
	  {
		  get
		  {
			return this.progress;
		  }
	  }
	}

}