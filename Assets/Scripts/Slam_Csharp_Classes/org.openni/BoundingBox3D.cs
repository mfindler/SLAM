namespace org.openni
{

	public class BoundingBox3D
	{
	  private readonly Point3D leftBottomNear;
	  private readonly Point3D rightTopFar;

	  public BoundingBox3D(Point3D paramPoint3D1, Point3D paramPoint3D2)
	  {
		this.leftBottomNear = paramPoint3D1;
		this.rightTopFar = paramPoint3D2;
	  }

	  public virtual Point3D LeftBottomNear
	  {
		  get
		  {
			return this.leftBottomNear;
		  }
	  }

	  public virtual Point3D RightTopFar
	  {
		  get
		  {
			return this.rightTopFar;
		  }
	  }

	  public virtual Point3D Mins
	  {
		  get
		  {
			return LeftBottomNear;
		  }
	  }

	  public virtual Point3D Maxs
	  {
		  get
		  {
			return RightTopFar;
		  }
	  }
	}

}