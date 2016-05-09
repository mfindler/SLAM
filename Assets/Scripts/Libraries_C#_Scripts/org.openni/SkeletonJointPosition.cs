namespace org.openni
{

	public class SkeletonJointPosition
	{
	  private Point3D position;
	  private float confidence;

	  public SkeletonJointPosition(Point3D paramPoint3D, float paramFloat)
	  {
		this.position = paramPoint3D;
		this.confidence = paramFloat;
	  }

	  public virtual Point3D Position
	  {
		  get
		  {
			return this.position;
		  }
	  }

	  public virtual float Confidence
	  {
		  get
		  {
			return this.confidence;
		  }
	  }
	}

}