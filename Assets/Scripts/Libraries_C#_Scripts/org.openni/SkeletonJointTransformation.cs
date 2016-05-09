namespace org.openni
{

	public class SkeletonJointTransformation
	{
	  private SkeletonJointPosition position;
	  private SkeletonJointOrientation orientation;

	  public SkeletonJointTransformation(SkeletonJointPosition paramSkeletonJointPosition, SkeletonJointOrientation paramSkeletonJointOrientation)
	  {
		this.position = paramSkeletonJointPosition;
		this.orientation = paramSkeletonJointOrientation;
	  }

	  public virtual SkeletonJointPosition Position
	  {
		  get
		  {
			return this.position;
		  }
	  }

	  public virtual SkeletonJointOrientation Orientation
	  {
		  get
		  {
			return this.orientation;
		  }
	  }
	}

}