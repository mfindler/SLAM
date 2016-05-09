using System.Collections.Generic;

namespace org.openni
{

	public sealed class SkeletonPoseProcessingMode
	{
	  public static readonly SkeletonPoseProcessingMode NONE = new SkeletonPoseProcessingMode("NONE", InnerEnum.NONE, 0);
	  public static readonly SkeletonPoseProcessingMode ALL = new SkeletonPoseProcessingMode("ALL", InnerEnum.ALL, 1);

	  private static readonly IList<SkeletonPoseProcessingMode> valueList = new List<SkeletonPoseProcessingMode>();

	  static SkeletonPoseProcessingMode()
	  {
		  valueList.Add(NONE);
		  valueList.Add(ALL);
	  }

	  public enum InnerEnum
	  {
		  NONE,
		  ALL
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private SkeletonPoseProcessingMode(string name, InnerEnum innerEnum, int paramInt)
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

	  public static SkeletonPoseProcessingMode fromNative(int paramInt)
	  {
		foreach (SkeletonPoseProcessingMode localSkeletonPoseProcessingMode in)
		{
		  if (localSkeletonPoseProcessingMode.val == paramInt)
		  {
			return localSkeletonPoseProcessingMode;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<SkeletonPoseProcessingMode> values()
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

		public static SkeletonPoseProcessingMode valueOf(string name)
		{
			foreach (SkeletonPoseProcessingMode enumInstance in SkeletonPoseProcessingMode.values())
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