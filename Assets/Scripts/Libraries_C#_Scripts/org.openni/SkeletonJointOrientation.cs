namespace org.openni
{

	public class SkeletonJointOrientation
	{
	  private float x1;
	  private float y1;
	  private float z1;
	  private float x2;
	  private float y2;
	  private float z2;
	  private float x3;
	  private float y3;
	  private float z3;
	  private float confidence;

	  public SkeletonJointOrientation(float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4, float paramFloat5, float paramFloat6, float paramFloat7, float paramFloat8, float paramFloat9, float paramFloat10)
	  {
		this.x1 = paramFloat1;
		this.y1 = paramFloat2;
		this.z1 = paramFloat3;
		this.x2 = paramFloat4;
		this.y2 = paramFloat5;
		this.z2 = paramFloat6;
		this.x3 = paramFloat7;
		this.y3 = paramFloat8;
		this.z3 = paramFloat9;
		this.confidence = paramFloat10;
	  }

	  public virtual float X1
	  {
		  get
		  {
			return this.x1;
		  }
	  }

	  public virtual float Y1
	  {
		  get
		  {
			return this.y1;
		  }
	  }

	  public virtual float Z1
	  {
		  get
		  {
			return this.z1;
		  }
	  }

	  public virtual float X2
	  {
		  get
		  {
			return this.x2;
		  }
	  }

	  public virtual float Y2
	  {
		  get
		  {
			return this.y2;
		  }
	  }

	  public virtual float Z2
	  {
		  get
		  {
			return this.z2;
		  }
	  }

	  public virtual float X3
	  {
		  get
		  {
			return this.x3;
		  }
	  }

	  public virtual float Y3
	  {
		  get
		  {
			return this.y3;
		  }
	  }

	  public virtual float Z3
	  {
		  get
		  {
			return this.z3;
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