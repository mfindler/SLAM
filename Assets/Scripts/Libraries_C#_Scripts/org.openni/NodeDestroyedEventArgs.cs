namespace org.openni
{

	public class NodeDestroyedEventArgs : EventArgs
	{
	  private string destroyedNodeName;

	  public NodeDestroyedEventArgs(string paramString)
	  {
		this.destroyedNodeName = paramString;
	  }

	  public virtual string DestroyedNodeName
	  {
		  get
		  {
			return this.destroyedNodeName;
		  }
	  }
	}

}