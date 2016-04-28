namespace org.openni
{

	public class ImageMetaData : MapMetaData
	{
	  public ImageMetaData() : base(PixelFormat.RGB24, new ImageMap())
	  {
		PixelFormat = PixelFormat.RGB24;
	  }

	  public virtual PixelFormat PixelFormat
	  {
		  set
		  {
			base.PixelFormat = value;
		  }
	  }

	  public virtual ImageMap Data
	  {
		  get
		  {
			return (ImageMap)base.Data;
		  }
	  }
	}

}