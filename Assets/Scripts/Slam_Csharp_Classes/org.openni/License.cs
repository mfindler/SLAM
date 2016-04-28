namespace org.openni
{

	public class License
	{
	  private readonly string vendor;
	  private readonly string key;

	  public License(string paramString1, string paramString2)
	  {
		this.vendor = paramString1;
		this.key = paramString2;
	  }

	  public virtual string Vendor
	  {
		  get
		  {
			return this.vendor;
		  }
	  }

	  public virtual string Key
	  {
		  get
		  {
			return this.key;
		  }
	  }
	}

}