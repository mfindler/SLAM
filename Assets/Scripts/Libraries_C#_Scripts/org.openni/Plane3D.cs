namespace org.openni
{

	public class Plane3D
	{
	  private readonly Point3D normal;
	  private readonly Point3D point;

	  public Plane3D(Point3D paramPoint3D1, Point3D paramPoint3D2)
	  {
		this.normal = paramPoint3D1;
		this.point = paramPoint3D2;
	  }

	  public virtual Point3D Normal
	  {
		  get
		  {
			return this.normal;
		  }
	  }

	  public virtual Point3D Point
	  {
		  get
		  {
			return this.point;
		  }
	  }
	}

}