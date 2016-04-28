namespace org.openni
{

	public class FieldOfView
	{
	  private double hFOV;
	  private double vFOV;

	  public FieldOfView(double paramDouble1, double paramDouble2)
	  {
		this.hFOV = paramDouble1;
		this.vFOV = paramDouble2;
	  }

	  public virtual double HFOV
	  {
		  get
		  {
			return this.hFOV;
		  }
		  set
		  {
			this.hFOV = value;
		  }
	  }


	  public virtual double VFOV
	  {
		  get
		  {
			return this.vFOV;
		  }
		  set
		  {
			this.vFOV = value;
		  }
	  }

	}

}