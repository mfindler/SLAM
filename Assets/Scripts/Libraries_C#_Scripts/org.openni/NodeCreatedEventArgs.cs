namespace org.openni
{

	public class NodeCreatedEventArgs : EventArgs
	{
	  private ProductionNode createdNode;

	  public NodeCreatedEventArgs(ProductionNode paramProductionNode)
	  {
		this.createdNode = paramProductionNode;
	  }

	  public virtual ProductionNode CreatedNode
	  {
		  get
		  {
			return this.createdNode;
		  }
	  }
	}

}