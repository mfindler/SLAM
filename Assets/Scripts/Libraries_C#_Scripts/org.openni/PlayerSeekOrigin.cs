using System.Collections.Generic;

namespace org.openni
{

	public sealed class PlayerSeekOrigin
	{
	  public static readonly PlayerSeekOrigin SET = new PlayerSeekOrigin("SET", InnerEnum.SET, 0);
	  public static readonly PlayerSeekOrigin CURRENT = new PlayerSeekOrigin("CURRENT", InnerEnum.CURRENT, 1);
	  public static readonly PlayerSeekOrigin END = new PlayerSeekOrigin("END", InnerEnum.END, 2);

	  private static readonly IList<PlayerSeekOrigin> valueList = new List<PlayerSeekOrigin>();

	  static PlayerSeekOrigin()
	  {
		  valueList.Add(SET);
		  valueList.Add(CURRENT);
		  valueList.Add(END);
	  }

	  public enum InnerEnum
	  {
		  SET,
		  CURRENT,
		  END
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private PlayerSeekOrigin(string name, InnerEnum innerEnum, int paramInt)
	  {
		this.val = paramInt;

		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  public int toNative()
	  {
		return this.val;
	  }

	  public static PlayerSeekOrigin fromNative(int paramInt)
	  {
		foreach (PlayerSeekOrigin localPlayerSeekOrigin in)
		{
		  if (localPlayerSeekOrigin.val == paramInt)
		  {
			return localPlayerSeekOrigin;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<PlayerSeekOrigin> values()
		{
			return valueList;
		}

		public InnerEnum InnerEnumValue()
		{
			return innerEnumValue;
		}

		public int ordinal()
		{
			return ordinalValue;
		}

		public override string ToString()
		{
			return nameValue;
		}

		public static PlayerSeekOrigin valueOf(string name)
		{
			foreach (PlayerSeekOrigin enumInstance in PlayerSeekOrigin.values())
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}

}