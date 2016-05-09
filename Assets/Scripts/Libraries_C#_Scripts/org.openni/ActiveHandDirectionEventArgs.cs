namespace org.openni
{

	public class ActiveHandDirectionEventArgs : EventArgs
	{
	  private readonly int id;
	  private readonly Point3D position;
	  private readonly float time;
	  private readonly Direction direction;

	  public ActiveHandDirectionEventArgs(int paramInt, Point3D paramPoint3D, float paramFloat, Direction paramDirection)
	  {
		this.id = paramInt;
		this.position = paramPoint3D;
		this.time = paramFloat;
		this.direction = paramDirection;
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

	  public virtual Direction Direction
	  {
		  get
		  {
			return this.direction;
		  }
	  }
	}

}