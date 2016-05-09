namespace org.openni
{

	public class ActiveHandEventArgs : EventArgs
	{
	  private readonly int id;
	  private readonly Point3D position;
	  private readonly float time;

	  public ActiveHandEventArgs(int paramInt, Point3D paramPoint3D, float paramFloat)
	  {
		this.id = paramInt;
		this.position = paramPoint3D;
		this.time = paramFloat;
	  }

	  public virtual int Id
	  {
		  get
		  {
			return this.id;
		  }
	  }

	  public virtual Point3D Position
	  {
		  get
		  {
			return this.position;
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