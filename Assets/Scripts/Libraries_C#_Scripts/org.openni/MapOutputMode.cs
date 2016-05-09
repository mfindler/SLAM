namespace org.openni
{

	public class MapOutputMode
	{
	  private int xRes;
	  private int yRes;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
	  private int FPS_Renamed;

	  public MapOutputMode(int paramInt1, int paramInt2, int paramInt3)
	  {
		this.xRes = paramInt1;
		this.yRes = paramInt2;
		this.FPS_Renamed = paramInt3;
	  }

	  public virtual int XRes
	  {
		  set
		  {
			this.xRes = value;
		  }
		  get
		  {
			return this.xRes;
		  }
	  }

	  public virtual int YRes
	  {
		  set
		  {
			this.yRes = value;
		  }
		  get
		  {
			return this.yRes;
		  }
	  }

	  public virtual int FPS
	  {
		  set
		  {
			this.FPS_Renamed = value;
		  }
		  get
		  {
			return this.FPS_Renamed;
		  }
	  }



	}

}