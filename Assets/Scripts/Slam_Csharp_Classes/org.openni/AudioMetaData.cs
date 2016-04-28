namespace org.openni
{

	public class AudioMetaData : OutputMetaData
	{
	  private int sampleRate;
	  private short bitsPerSample;
	  private sbyte numberOfChannels;

	  public virtual int SampleRate
	  {
		  get
		  {
			return this.sampleRate;
		  }
		  set
		  {
			this.sampleRate = value;
		  }
	  }


	  public virtual short BitsPerSample
	  {
		  get
		  {
			return this.bitsPerSample;
		  }
		  set
		  {
			this.bitsPerSample = value;
		  }
	  }


	  public virtual sbyte NumberOfChannels
	  {
		  get
		  {
			return this.numberOfChannels;
		  }
		  set
		  {
			this.numberOfChannels = value;
		  }
	  }


	  public virtual ByteBuffer createByteBuffer()
	  {
		int i = DataSize;
		ByteBuffer localByteBuffer = ByteBuffer.allocateDirect(i);
		localByteBuffer.order(ByteOrder.LITTLE_ENDIAN);
		NativeMethods.copyToBuffer(localByteBuffer, DataPtr, i);
		return localByteBuffer;
	  }
	}

}