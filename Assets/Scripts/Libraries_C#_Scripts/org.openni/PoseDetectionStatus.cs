using System.Collections.Generic;

namespace org.openni
{

	public sealed class PoseDetectionStatus
	{
	  public static readonly PoseDetectionStatus OK = new PoseDetectionStatus("OK", InnerEnum.OK, 0);
	  public static readonly PoseDetectionStatus NO_USER = new PoseDetectionStatus("NO_USER", InnerEnum.NO_USER, 1);
	  public static readonly PoseDetectionStatus TOP_FOV = new PoseDetectionStatus("TOP_FOV", InnerEnum.TOP_FOV, 2);
	  public static readonly PoseDetectionStatus SIDE_FOV = new PoseDetectionStatus("SIDE_FOV", InnerEnum.SIDE_FOV, 3);
	  public static readonly PoseDetectionStatus ERROR = new PoseDetectionStatus("ERROR", InnerEnum.ERROR, 4);
	  public static readonly PoseDetectionStatus NO_TRACKING = new PoseDetectionStatus("NO_TRACKING", InnerEnum.NO_TRACKING, 5);

	  private static readonly IList<PoseDetectionStatus> valueList = new List<PoseDetectionStatus>();

	  static PoseDetectionStatus()
	  {
		  valueList.Add(OK);
		  valueList.Add(NO_USER);
		  valueList.Add(TOP_FOV);
		  valueList.Add(SIDE_FOV);
		  valueList.Add(ERROR);
		  valueList.Add(NO_TRACKING);
	  }

	  public enum InnerEnum
	  {
		  OK,
		  NO_USER,
		  TOP_FOV,
		  SIDE_FOV,
		  ERROR,
		  NO_TRACKING
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private PoseDetectionStatus(string name, InnerEnum innerEnum, int paramInt)
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

	  public static PoseDetectionStatus fromNative(int paramInt)
	  {
		foreach (PoseDetectionStatus localPoseDetectionStatus in)
		{
		  if (localPoseDetectionStatus.val == paramInt)
		  {
			return localPoseDetectionStatus;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<PoseDetectionStatus> values()
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

		public static PoseDetectionStatus valueOf(string name)
		{
			foreach (PoseDetectionStatus enumInstance in PoseDetectionStatus.values())
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