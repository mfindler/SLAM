namespace org.openni
{

	public class GestureRecognizedEventArgs : EventArgs
	{
	  private readonly string gesture;
	  private readonly Point3D idPosition;
	  private readonly Point3D endPosition;

	  public GestureRecognizedEventArgs(string paramString, Point3D paramPoint3D1, Point3D paramPoint3D2)
	  {
		this.gesture = paramString;
		this.idPosition = paramPoint3D1;
		this.endPosition = paramPoint3D2;
	  }

	  public virtual string Gesture
	  {
		  get
		  {
			return this.gesture;
		  }
	  }

	  public virtual Point3D IdPosition
	  {
		  get
		  {
			return this.idPosition;
		  }
	  }

	  public virtual Point3D EndPosition
	  {
		  get
		  {
			return this.endPosition;
		  }
	  }
	}

}