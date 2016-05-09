namespace org.openni
{

	public class Cropping
	{
	  private int xOffset;
	  private int yOffset;
	  private int xSize;
	  private int ySize;
	  private bool enabled;

	  public Cropping(int paramInt1, int paramInt2, int paramInt3, int paramInt4, bool paramBoolean)
	  {
		this.xOffset = paramInt1;
		this.yOffset = paramInt2;
		this.xSize = paramInt3;
		this.ySize = paramInt4;
		this.enabled = paramBoolean;
	  }

	  public virtual int XOffset
	  {
		  get
		  {
			return this.xOffset;
		  }
		  set
		  {
			this.xOffset = value;
		  }
	  }


	  public virtual int YOffset
	  {
		  get
		  {
			return this.yOffset;
		  }
		  set
		  {
			this.yOffset = value;
		  }
	  }


	  public virtual int XSize
	  {
		  get
		  {
			return this.xSize;
		  }
		  set
		  {
			this.xSize = value;
		  }
	  }


	  public virtual int YSize
	  {
		  get
		  {
			return this.ySize;
		  }
		  set
		  {
			this.ySize = value;
		  }
	  }


	  public virtual bool Enabled
	  {
		  get
		  {
			return this.enabled;
		  }
		  set
		  {
			this.enabled = value;
		  }
	  }

	}

}