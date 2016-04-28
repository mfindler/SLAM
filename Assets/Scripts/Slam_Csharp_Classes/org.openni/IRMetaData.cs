namespace org.openni
{

	public class IRMetaData : MapMetaData
	{
	  public IRMetaData() : base(PixelFormat.GRAYSCALE_16BIT, new IRMap())
	  {
	  }

	  public virtual IRMap Data
	  {
		  get
		  {
			return (IRMap)base.Data;
		  }
	  }
	}

}