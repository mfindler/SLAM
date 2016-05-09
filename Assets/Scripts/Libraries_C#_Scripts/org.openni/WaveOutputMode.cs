namespace org.openni
{

	public class WaveOutputMode
	{
	  private int sampleRate;
	  private short bitsPerSample;
	  private sbyte numberOfChannels;

	  public WaveOutputMode(int paramInt, short paramShort, sbyte paramByte)
	  {
		this.sampleRate = paramInt;
		this.bitsPerSample = paramShort;
		this.numberOfChannels = paramByte;
	  }

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

	}

}