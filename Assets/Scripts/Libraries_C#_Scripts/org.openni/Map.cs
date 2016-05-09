namespace org.openni
{

	public class Map
	{
	  protected internal long ptr;
	  protected internal int xRes;
	  protected internal int yRes;
	  protected internal int bytesPerPixel;

	  internal Map()
	  {
	  }

	  internal Map(long paramLong, int paramInt1, int paramInt2, int paramInt3)
	  {
		this.ptr = paramLong;
		this.xRes = paramInt1;
		this.yRes = paramInt2;
		this.bytesPerPixel = paramInt3;
	  }

	  public virtual long NativePtr
	  {
		  get
		  {
			return this.ptr;
		  }
		  set
		  {
			this.ptr = value;
		  }
	  }


	  protected internal virtual ByteBuffer createByteBuffer()
	  {
		int i = this.xRes * this.yRes * this.bytesPerPixel;
		ByteBuffer localByteBuffer = ByteBuffer.allocateDirect(i);
		localByteBuffer.order(ByteOrder.LITTLE_ENDIAN);
		NativeMethods.copyToBuffer(localByteBuffer, this.ptr, i);
		return localByteBuffer;
	  }

	  public virtual void copyToBuffer(ByteBuffer paramByteBuffer, int paramInt)
	  {
		NativeMethods.copyToBuffer(paramByteBuffer, this.ptr, paramInt);
	  }

	  protected internal virtual long getPixelPtr(int paramInt1, int paramInt2)
	  {
		return this.ptr + (paramInt2 * this.xRes + paramInt1) * this.bytesPerPixel;
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
		  }
	  }


	  public virtual int BytesPerPixel
	  {
		  get
		  {
			return this.bytesPerPixel;
		  }
		  set
		  {
			this.bytesPerPixel = value;
		  }
	  }

	}

}