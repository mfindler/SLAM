using System.Collections.Generic;

namespace org.openni
{

	public sealed class CalibrationProgressStatus
	{
	  public static readonly CalibrationProgressStatus OK = new CalibrationProgressStatus("OK", InnerEnum.OK, 0);
	  public static readonly CalibrationProgressStatus NO_USER = new CalibrationProgressStatus("NO_USER", InnerEnum.NO_USER, 1);
	  public static readonly CalibrationProgressStatus ARM = new CalibrationProgressStatus("ARM", InnerEnum.ARM, 2);
	  public static readonly CalibrationProgressStatus LEG = new CalibrationProgressStatus("LEG", InnerEnum.LEG, 3);
	  public static readonly CalibrationProgressStatus HEAD = new CalibrationProgressStatus("HEAD", InnerEnum.HEAD, 4);
	  public static readonly CalibrationProgressStatus TORSO = new CalibrationProgressStatus("TORSO", InnerEnum.TORSO, 5);
	  public static readonly CalibrationProgressStatus TOP_FOV = new CalibrationProgressStatus("TOP_FOV", InnerEnum.TOP_FOV, 6);
	  public static readonly CalibrationProgressStatus SIDE_FOV = new CalibrationProgressStatus("SIDE_FOV", InnerEnum.SIDE_FOV, 7);
	  public static readonly CalibrationProgressStatus POSE = new CalibrationProgressStatus("POSE", InnerEnum.POSE, 8);
	  public static readonly CalibrationProgressStatus MANUAL_ABORT = new CalibrationProgressStatus("MANUAL_ABORT", InnerEnum.MANUAL_ABORT, 9);
	  public static readonly CalibrationProgressStatus MANUAL_RESET = new CalibrationProgressStatus("MANUAL_RESET", InnerEnum.MANUAL_RESET, 10);
	  public static readonly CalibrationProgressStatus TIMEOUT_FAIL = new CalibrationProgressStatus("TIMEOUT_FAIL", InnerEnum.TIMEOUT_FAIL, 11);

	  private static readonly IList<CalibrationProgressStatus> valueList = new List<CalibrationProgressStatus>();

	  static CalibrationProgressStatus()
	  {
		  valueList.Add(OK);
		  valueList.Add(NO_USER);
		  valueList.Add(ARM);
		  valueList.Add(LEG);
		  valueList.Add(HEAD);
		  valueList.Add(TORSO);
		  valueList.Add(TOP_FOV);
		  valueList.Add(SIDE_FOV);
		  valueList.Add(POSE);
		  valueList.Add(MANUAL_ABORT);
		  valueList.Add(MANUAL_RESET);
		  valueList.Add(TIMEOUT_FAIL);
	  }

	  public enum InnerEnum
	  {
		  OK,
		  NO_USER,
		  ARM,
		  LEG,
		  HEAD,
		  TORSO,
		  TOP_FOV,
		  SIDE_FOV,
		  POSE,
		  MANUAL_ABORT,
		  MANUAL_RESET,
		  TIMEOUT_FAIL
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private CalibrationProgressStatus(string name, InnerEnum innerEnum, int paramInt)
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

	  public static CalibrationProgressStatus fromNative(int paramInt)
	  {
		foreach (CalibrationProgressStatus localCalibrationProgressStatus in)
		{
		  if (localCalibrationProgressStatus.val == paramInt)
		  {
			return localCalibrationProgressStatus;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<CalibrationProgressStatus> values()
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

		public static CalibrationProgressStatus valueOf(string name)
		{
			foreach (CalibrationProgressStatus enumInstance in CalibrationProgressStatus.values())
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