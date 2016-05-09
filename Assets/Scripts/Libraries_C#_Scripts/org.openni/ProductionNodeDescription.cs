namespace org.openni
{

	public class ProductionNodeDescription
	{
	  private NodeType type;
	  private string vendor;
	  private string name;
	  private Version version;

	  public ProductionNodeDescription(NodeType paramNodeType, string paramString1, string paramString2, Version paramVersion)
	  {
		this.type = paramNodeType;
		this.vendor = paramString1;
		this.name = paramString2;
		this.version = paramVersion;
	  }

	  private ProductionNodeDescription(int paramInt, string paramString1, string paramString2, Version paramVersion) : this(new NodeType(paramInt), paramString1, paramString2, paramVersion)
	  {
	  }

	  public virtual NodeType Type
	  {
		  get
		  {
			return this.type;
		  }
	  }

	  public virtual string Vendor
	  {
		  get
		  {
			return this.vendor;
		  }
	  }

	  public virtual string Name
	  {
		  get
		  {
			return this.name;
		  }
	  }

	  public virtual Version Version
	  {
		  get
		  {
			return this.version;
		  }
	  }

	  protected internal virtual long createNative()
	  {
		return NativeMethods.createProductionNodeDescription(this.type.toNative(), this.vendor, this.name, this.version.Major, this.version.Minor, this.version.Maintenance, this.version.Build);
	  }

	  protected internal static void freeNative(long paramLong)
	  {
		NativeMethods.freeProductionNodeDescription(paramLong);
	  }
	}

}