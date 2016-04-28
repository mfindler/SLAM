namespace org.openni
{

	public class GesturePositionEventArgs : EventArgs
	{
	  private readonly string gesture;
	  private readonly Point3D position;

	  public GesturePositionEventArgs(string paramString, Point3D paramPoint3D)
	  {
		this.gesture = paramString;
		this.position = paramPoint3D;
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
	}

}