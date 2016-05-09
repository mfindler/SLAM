namespace org.openni
{

	public abstract class MapMetaData : OutputMetaData
	{
	  private int xRes;
	  private int yRes;
	  private int xOffset;
	  private int yOffset;
	  private int fullXRes;
	  private int fullYRes;
	  private PixelFormat pixelFormat;
//JAVA TO C# CONVERTER NOTE: Fields cannot have the same name as methods:
	  private int FPS_Renamed;
	  private Map map;

	  internal MapMetaData(PixelFormat paramPixelFormat, Map paramMap)
	  {
		this.pixelFormat = paramPixelFormat;
		this.map = paramMap;
	  }

	  public virtual int XRes
	  {
		  get
		  {
			return this.xRes;
		  }
		  set
		  {
			this.xRes = value;
			this.map.XRes = value;
		  }
	  }


	  public virtual int YRes
	  {
		  get
		  {
			return this.yRes;
		  }
		  set
		  {
			this.yRes = value;
			this.map.YRes = value;
		  }
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


	  public virtual int FullXRes
	  {
		  get
		  {
			return this.fullXRes;
		  }
		  set
		  {
			this.fullXRes = value;
		  }
	  }


	  public virtual int FullYRes
	  {
		  get
		  {
			return this.fullYRes;
		  }
		  set
		  {
			this.fullYRes = value;
		  }
	  }


	  public virtual PixelFormat PixelFormat
	  {
		  get
		  {
			return this.pixelFormat;
		  }
		  set
		  {
			this.pixelFormat = value;
			this.map.BytesPerPixel = value.BytesPerPixel;
		  }
	  }

	  public virtual int FPS
	  {
		  get
		  {
			return this.FPS_Renamed;
		  }
		  set
		  {
			this.FPS_Renamed = value;
		  }
	  }


	  public virtual Map Data
	  {
		  get
		  {
			return this.map;
		  }
	  }

	  public virtual long DataPtr
	  {
		  set
		  {
			base.DataPtr = value;
			this.map.NativePtr = value;
		  }
	  }

	}

}