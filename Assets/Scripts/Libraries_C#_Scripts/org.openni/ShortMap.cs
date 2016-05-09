using System.Collections;

namespace org.openni
{

	public class ShortMap : IDictionary
	{
	  private const int BYTES_PER_PIXEL = 2;

	  internal ShortMap()
	  {
		BytesPerPixel = 2;
	  }

	  internal ShortMap(long paramLong, int paramInt1, int paramInt2) : base(paramLong, paramInt1, paramInt2, 2)
	  {
	  }

	  public virtual short readPixel(int paramInt1, int paramInt2)
	  {
		return NativeMethods.readShort(getPixelPtr(paramInt1, paramInt2));
	  }

	  public virtual ShortBuffer createShortBuffer()
	  {
		return createByteBuffer().asShortBuffer();
	  }
	}

}