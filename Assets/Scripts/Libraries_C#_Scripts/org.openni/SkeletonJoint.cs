using System.Collections.Generic;

namespace org.openni
{

	public sealed class SkeletonJoint
	{
	  public static readonly SkeletonJoint HEAD = new SkeletonJoint("HEAD", InnerEnum.HEAD, 1);
	  public static readonly SkeletonJoint NECK = new SkeletonJoint("NECK", InnerEnum.NECK, 2);
	  public static readonly SkeletonJoint TORSO = new SkeletonJoint("TORSO", InnerEnum.TORSO, 3);
	  public static readonly SkeletonJoint WAIST = new SkeletonJoint("WAIST", InnerEnum.WAIST, 4);
	  public static readonly SkeletonJoint LEFT_COLLAR = new SkeletonJoint("LEFT_COLLAR", InnerEnum.LEFT_COLLAR, 5);
	  public static readonly SkeletonJoint LEFT_SHOULDER = new SkeletonJoint("LEFT_SHOULDER", InnerEnum.LEFT_SHOULDER, 6);
	  public static readonly SkeletonJoint LEFT_ELBOW = new SkeletonJoint("LEFT_ELBOW", InnerEnum.LEFT_ELBOW, 7);
	  public static readonly SkeletonJoint LEFT_WRIST = new SkeletonJoint("LEFT_WRIST", InnerEnum.LEFT_WRIST, 8);
	  public static readonly SkeletonJoint LEFT_HAND = new SkeletonJoint("LEFT_HAND", InnerEnum.LEFT_HAND, 9);
	  public static readonly SkeletonJoint LEFT_FINGER_TIP = new SkeletonJoint("LEFT_FINGER_TIP", InnerEnum.LEFT_FINGER_TIP, 10);
	  public static readonly SkeletonJoint RIGHT_COLLAR = new SkeletonJoint("RIGHT_COLLAR", InnerEnum.RIGHT_COLLAR, 11);
	  public static readonly SkeletonJoint RIGHT_SHOULDER = new SkeletonJoint("RIGHT_SHOULDER", InnerEnum.RIGHT_SHOULDER, 12);
	  public static readonly SkeletonJoint RIGHT_ELBOW = new SkeletonJoint("RIGHT_ELBOW", InnerEnum.RIGHT_ELBOW, 13);
	  public static readonly SkeletonJoint RIGHT_WRIST = new SkeletonJoint("RIGHT_WRIST", InnerEnum.RIGHT_WRIST, 14);
	  public static readonly SkeletonJoint RIGHT_HAND = new SkeletonJoint("RIGHT_HAND", InnerEnum.RIGHT_HAND, 15);
	  public static readonly SkeletonJoint RIGHT_FINGER_TIP = new SkeletonJoint("RIGHT_FINGER_TIP", InnerEnum.RIGHT_FINGER_TIP, 16);
	  public static readonly SkeletonJoint LEFT_HIP = new SkeletonJoint("LEFT_HIP", InnerEnum.LEFT_HIP, 17);
	  public static readonly SkeletonJoint LEFT_KNEE = new SkeletonJoint("LEFT_KNEE", InnerEnum.LEFT_KNEE, 18);
	  public static readonly SkeletonJoint LEFT_ANKLE = new SkeletonJoint("LEFT_ANKLE", InnerEnum.LEFT_ANKLE, 19);
	  public static readonly SkeletonJoint LEFT_FOOT = new SkeletonJoint("LEFT_FOOT", InnerEnum.LEFT_FOOT, 20);
	  public static readonly SkeletonJoint RIGHT_HIP = new SkeletonJoint("RIGHT_HIP", InnerEnum.RIGHT_HIP, 21);
	  public static readonly SkeletonJoint RIGHT_KNEE = new SkeletonJoint("RIGHT_KNEE", InnerEnum.RIGHT_KNEE, 22);
	  public static readonly SkeletonJoint RIGHT_ANKLE = new SkeletonJoint("RIGHT_ANKLE", InnerEnum.RIGHT_ANKLE, 23);
	  public static readonly SkeletonJoint RIGHT_FOOT = new SkeletonJoint("RIGHT_FOOT", InnerEnum.RIGHT_FOOT, 24);

	  private static readonly IList<SkeletonJoint> valueList = new List<SkeletonJoint>();

	  static SkeletonJoint()
	  {
		  valueList.Add(HEAD);
		  valueList.Add(NECK);
		  valueList.Add(TORSO);
		  valueList.Add(WAIST);
		  valueList.Add(LEFT_COLLAR);
		  valueList.Add(LEFT_SHOULDER);
		  valueList.Add(LEFT_ELBOW);
		  valueList.Add(LEFT_WRIST);
		  valueList.Add(LEFT_HAND);
		  valueList.Add(LEFT_FINGER_TIP);
		  valueList.Add(RIGHT_COLLAR);
		  valueList.Add(RIGHT_SHOULDER);
		  valueList.Add(RIGHT_ELBOW);
		  valueList.Add(RIGHT_WRIST);
		  valueList.Add(RIGHT_HAND);
		  valueList.Add(RIGHT_FINGER_TIP);
		  valueList.Add(LEFT_HIP);
		  valueList.Add(LEFT_KNEE);
		  valueList.Add(LEFT_ANKLE);
		  valueList.Add(LEFT_FOOT);
		  valueList.Add(RIGHT_HIP);
		  valueList.Add(RIGHT_KNEE);
		  valueList.Add(RIGHT_ANKLE);
		  valueList.Add(RIGHT_FOOT);
	  }

	  public enum InnerEnum
	  {
		  HEAD,
		  NECK,
		  TORSO,
		  WAIST,
		  LEFT_COLLAR,
		  LEFT_SHOULDER,
		  LEFT_ELBOW,
		  LEFT_WRIST,
		  LEFT_HAND,
		  LEFT_FINGER_TIP,
		  RIGHT_COLLAR,
		  RIGHT_SHOULDER,
		  RIGHT_ELBOW,
		  RIGHT_WRIST,
		  RIGHT_HAND,
		  RIGHT_FINGER_TIP,
		  LEFT_HIP,
		  LEFT_KNEE,
		  LEFT_ANKLE,
		  LEFT_FOOT,
		  RIGHT_HIP,
		  RIGHT_KNEE,
		  RIGHT_ANKLE,
		  RIGHT_FOOT
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private SkeletonJoint(string name, InnerEnum innerEnum, int paramInt)
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

	  public static SkeletonJoint fromNative(int paramInt)
	  {
		foreach (SkeletonJoint localSkeletonJoint in)
		{
		  if (localSkeletonJoint.val == paramInt)
		  {
			return localSkeletonJoint;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<SkeletonJoint> values()
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

		public static SkeletonJoint valueOf(string name)
		{
			foreach (SkeletonJoint enumInstance in SkeletonJoint.values())
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