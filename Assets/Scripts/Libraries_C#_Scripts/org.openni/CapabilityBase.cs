namespace org.openni
{

	public class CapabilityBase : NodeWrapper
	{
	  private ProductionNode node;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public CapabilityBase(ProductionNode paramProductionNode) throws StatusException
	  public CapabilityBase(ProductionNode paramProductionNode) : base(paramProductionNode.Context, paramProductionNode.toNative(), true)
	  {
		this.node = paramProductionNode;
	  }
	}

}