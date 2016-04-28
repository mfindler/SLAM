using System.Collections.Generic;

namespace org.openni
{

	public sealed class SkeletonProfile
	{
	  public static readonly SkeletonProfile NONE = new SkeletonProfile("NONE", InnerEnum.NONE, 1);
	  public static readonly SkeletonProfile ALL = new SkeletonProfile("ALL", InnerEnum.ALL, 2);
	  public static readonly SkeletonProfile UPPER_BODY = new SkeletonProfile("UPPER_BODY", InnerEnum.UPPER_BODY, 3);
	  public static readonly SkeletonProfile LOWER_BODY = new SkeletonProfile("LOWER_BODY", InnerEnum.LOWER_BODY, 4);
	  public static readonly SkeletonProfile HEAD_HANDS = new SkeletonProfile("HEAD_HANDS", InnerEnum.HEAD_HANDS, 5);

	  private static readonly IList<SkeletonProfile> valueList = new List<SkeletonProfile>();

	  static SkeletonProfile()
	  {
		  valueList.Add(NONE);
		  valueList.Add(ALL);
		  valueList.Add(UPPER_BODY);
		  valueList.Add(LOWER_BODY);
		  valueList.Add(HEAD_HANDS);
	  }

	  public enum InnerEnum
	  {
		  NONE,
		  ALL,
		  UPPER_BODY,
		  LOWER_BODY,
		  HEAD_HANDS
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private SkeletonProfile(string name, InnerEnum innerEnum, int paramInt)
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

	  public static SkeletonProfile fromNative(int paramInt)
	  {
		foreach (SkeletonProfile localSkeletonProfile in)
		{
		  if (localSkeletonProfile.val == paramInt)
		  {
			return localSkeletonProfile;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<SkeletonProfile> values()
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

		public static SkeletonProfile valueOf(string name)
		{
			foreach (SkeletonProfile enumInstance in SkeletonProfile.values())
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