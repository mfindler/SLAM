namespace org.openni
{

	public class Point3D
	{
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
	  private float X_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
	  private float Y_Renamed;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
	  private float Z_Renamed;

	  public Point3D(float paramFloat1, float paramFloat2, float paramFloat3)
	  {
		this.X_Renamed = paramFloat1;
		this.Y_Renamed = paramFloat2;
		this.Z_Renamed = paramFloat3;
	  }

	  public Point3D() : this(0.0F, 0.0F, 0.0F)
	  {
	  }

	  public virtual void setPoint(float paramFloat1, float paramFloat2, float paramFloat3)
	  {
		this.X_Renamed = paramFloat1;
		this.Y_Renamed = paramFloat2;
		this.Z_Renamed = paramFloat3;
	  }

	  public virtual float X
	  {
		  get
		  {
			return this.X_Renamed;
		  }
	  }

	  public virtual float Y
	  {
		  get
		  {
			return this.Y_Renamed;
		  }
	  }

	  public virtual float Z
	  {
		  get
		  {
			return this.Z_Renamed;
		  }
	  }
	}

}