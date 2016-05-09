namespace org.openni
{

	public class XYCoordinates
	{
	  private int x;
	  private int y;

	  public XYCoordinates(int paramInt1, int paramInt2)
	  {
		this.x = paramInt1;
		this.y = paramInt2;
	  }

	  public virtual int X
	  {
		  set
		  {
			this.x = value;
		  }
		  get
		  {
			return this.x;
		  }
	  }

	  public virtual int Y
	  {
		  set
		  {
			this.y = value;
		  }
		  get
		  {
			return this.y;
		  }
	  }


	}

}