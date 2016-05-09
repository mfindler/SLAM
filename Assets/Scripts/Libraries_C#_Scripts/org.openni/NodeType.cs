namespace org.openni
{

	public class NodeType
	{
	  public static NodeType INVALID = new NodeType(0);
	  public static NodeType DEVICE = new NodeType(1);
	  public static NodeType DEPTH = new NodeType(2);
	  public static NodeType IMAGE = new NodeType(3);
	  public static NodeType AUDIO = new NodeType(4);
	  public static NodeType IR = new NodeType(5);
	  public static NodeType USER = new NodeType(6);
	  public static NodeType RECORDER = new NodeType(7);
	  public static NodeType PLAYER = new NodeType(8);
	  public static NodeType GESTURE = new NodeType(9);
	  public static NodeType SCENE = new NodeType(10);
	  public static NodeType HANDS = new NodeType(11);
	  public static NodeType CODEC = new NodeType(12);
	  public static NodeType PRODUCTION_NODE = new NodeType(13);
	  public static NodeType GENERATOR = new NodeType(14);
	  public static NodeType MAP_GENERATOR = new NodeType(15);
	  public static NodeType SCRIPT_NODE = new NodeType(16);
	  private readonly int val;

	  internal NodeType(int paramInt)
	  {
		this.val = paramInt;
	  }

	  public override int GetHashCode()
	  {
		int i = 1;
		i = 31 * i + this.val;
		return i;
	  }

	  public override bool Equals(object paramObject)
	  {
		if (this == paramObject)
		{
		  return true;
		}
		if (paramObject == null)
		{
		  return false;
		}
		if (this.GetType() != paramObject.GetType())
		{
		  return false;
		}
		NodeType localNodeType = (NodeType)paramObject;
		if (this.val != localNodeType.val)
		{
		  return false;
		}
		return true;
	  }

	  public virtual int toNative()
	  {
		return this.val;
	  }

	  public override string ToString()
	  {
		return NativeMethods.xnProductionNodeTypeToString(toNative());
	  }

	  public virtual bool Generator
	  {
		  get
		  {
			return NativeMethods.xnIsTypeGenerator(toNative());
		  }
	  }

	  public virtual bool isDerivedFrom(NodeType paramNodeType)
	  {
		return NativeMethods.xnIsTypeDerivedFrom(toNative(), paramNodeType.toNative());
	  }
	}

}