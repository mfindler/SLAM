using System.Collections;

namespace org.openni
{


	public class ImageMap : IDictionary
	{
	  public ImageMap()
	  {
	  }

	  public ImageMap(long paramLong, int paramInt1, int paramInt2, int paramInt3) : base(paramLong, paramInt1, paramInt2, paramInt3)
	  {
	  }

	  public virtual ByteBuffer createByteBuffer()
	  {
		return base.createByteBuffer();
	  }
	}

}