namespace org.openni
{

	public class CodecID
	{
	  public static readonly CodecID Null = new CodecID((sbyte)0, (sbyte)0, (sbyte)0, (sbyte)0);
	  public static readonly CodecID Uncompressed = new CodecID('N', 'O', 'N', 'E');
	  public static readonly CodecID Jpeg = new CodecID('J', 'P', 'E', 'G');
	  public static readonly CodecID Z16 = new CodecID('1', '6', 'z', 'P');
	  public static readonly CodecID Z16WithTables = new CodecID('1', '6', 'z', 'T');
	  public static readonly CodecID Z8 = new CodecID('I', 'm', '8', 'z');
	  private int value;

	  public CodecID(int paramInt)
	  {
		this.value = paramInt;
	  }

	  public CodecID(sbyte paramByte1, sbyte paramByte2, sbyte paramByte3, sbyte paramByte4) : this(paramByte4 << 24 | paramByte3 << 16 | paramByte2 << 8 | paramByte1)
	  {
	  }

	  public CodecID(char paramChar1, char paramChar2, char paramChar3, char paramChar4) : this((sbyte)paramChar1, (sbyte)paramChar2, (sbyte)paramChar3, (sbyte)paramChar4)
	  {
	  }

	  public override int GetHashCode()
	  {
		int i = 1;
		i = 31 * i + this.value;
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
		CodecID localCodecID = (CodecID)paramObject;
		if (this.value != localCodecID.value)
		{
		  return false;
		}
		return true;
	  }

	  public virtual int toNative()
	  {
		return this.value;
	  }
	}

}