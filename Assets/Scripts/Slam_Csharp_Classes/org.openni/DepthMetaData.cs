namespace org.openni
{

	public class DepthMetaData : MapMetaData
	{
	  private int zRes;

	  public DepthMetaData() : base(PixelFormat.GRAYSCALE_16BIT, new DepthMap())
	  {
	  }

	  public virtual int ZRes
	  {
		  get
		  {
			return this.zRes;
		  }
		  set
		  {
			this.zRes = value;
		  }
	  }


	  public virtual DepthMap Data
	  {
		  get
		  {
			return (DepthMap)base.Data;
		  }
	  }
	}

}