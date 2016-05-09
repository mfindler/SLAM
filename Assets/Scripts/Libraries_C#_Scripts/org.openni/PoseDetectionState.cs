using System.Collections.Generic;

namespace org.openni
{

	public sealed class PoseDetectionState
	{
	  public static readonly PoseDetectionState InPose = new PoseDetectionState("InPose", InnerEnum.InPose, 0);
	  public static readonly PoseDetectionState OutOfPose = new PoseDetectionState("OutOfPose", InnerEnum.OutOfPose, 1);
	  public static readonly PoseDetectionState Undefined = new PoseDetectionState("Undefined", InnerEnum.Undefined, 2);

	  private static readonly IList<PoseDetectionState> valueList = new List<PoseDetectionState>();

	  static PoseDetectionState()
	  {
		  valueList.Add(InPose);
		  valueList.Add(OutOfPose);
		  valueList.Add(Undefined);
	  }

	  public enum InnerEnum
	  {
		  InPose,
		  OutOfPose,
		  Undefined
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private PoseDetectionState(string name, InnerEnum innerEnum, int paramInt)
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

	  public static PoseDetectionState fromNative(int paramInt)
	  {
		foreach (PoseDetectionState localPoseDetectionState in)
		{
		  if (localPoseDetectionState.val == paramInt)
		  {
			return localPoseDetectionState;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<PoseDetectionState> values()
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

		public static PoseDetectionState valueOf(string name)
		{
			foreach (PoseDetectionState enumInstance in PoseDetectionState.values())
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