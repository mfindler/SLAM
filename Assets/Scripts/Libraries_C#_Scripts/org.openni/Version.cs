namespace org.openni
{

	public class Version
	{
	  private readonly sbyte major;
	  private readonly sbyte minor;
	  private readonly short maintenance;
	  private readonly int build;

	  public Version(sbyte paramByte1, sbyte paramByte2, short paramShort, int paramInt)
	  {
		this.major = paramByte1;
		this.minor = paramByte2;
		this.maintenance = paramShort;
		this.build = paramInt;
	  }

	  public virtual sbyte Major
	  {
		  get
		  {
			return this.major;
		  }
	  }

	  public virtual sbyte Minor
	  {
		  get
		  {
			return this.minor;
		  }
	  }

	  public virtual short Maintenance
	  {
		  get
		  {
			return this.maintenance;
		  }
	  }

	  public virtual int Build
	  {
		  get
		  {
			return this.build;
		  }
	  }
	}

}