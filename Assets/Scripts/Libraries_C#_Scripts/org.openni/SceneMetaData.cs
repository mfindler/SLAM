namespace org.openni
{

	public class SceneMetaData : MapMetaData
	{
	  public SceneMetaData() : base(PixelFormat.GRAYSCALE_16BIT, new SceneMap())
	  {
	  }

	  public virtual SceneMap Data
	  {
		  get
		  {
			return (SceneMap)base.Data;
		  }
	  }
	}

}