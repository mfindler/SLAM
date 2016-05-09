//Project: SLAM
//NAME OF DEVELOPER: P J SIDDHARTHA
//PROFESSOR: MICHEAL J. FINDLER
//Notes: 1. Comments with '////' are regarding the code which are to be worked on. 
//       2. Comments with '//' are used for commenting some parts of code for testing purpose.
//       3. Comments with '///' are used for code which is not required.



using System.Collections.Generic;

namespace org.openni
{

	public sealed class Direction
	{
	  public static readonly Direction ILLEGAL = new Direction("ILLEGAL", InnerEnum.ILLEGAL, 0);
	  public static readonly Direction LEFT = new Direction("LEFT", InnerEnum.LEFT, 1);
	  public static readonly Direction RIGHT = new Direction("RIGHT", InnerEnum.RIGHT, 2);
	  public static readonly Direction UP = new Direction("UP", InnerEnum.UP, 3);
	  public static readonly Direction DOWN = new Direction("DOWN", InnerEnum.DOWN, 4);
	  public static readonly Direction FORWARD = new Direction("FORWARD", InnerEnum.FORWARD, 5);
	  public static readonly Direction BACKWARD = new Direction("BACKWARD", InnerEnum.BACKWARD, 6);

	  private static readonly IList<Direction> valueList = new List<Direction>();

	  static Direction()
	  {
		  valueList.Add(ILLEGAL);
		  valueList.Add(LEFT);
		  valueList.Add(RIGHT);
		  valueList.Add(UP);
		  valueList.Add(DOWN);
		  valueList.Add(FORWARD);
		  valueList.Add(BACKWARD);
	  }

	  public enum InnerEnum
	  {
		  ILLEGAL,
		  LEFT,
		  RIGHT,
		  UP,
		  DOWN,
		  FORWARD,
		  BACKWARD
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private Direction(string name, InnerEnum innerEnum, int paramInt)
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

	  public static Direction fromNative(int paramInt)
	  {
		foreach (Direction localDirection in)
		{
		  if (localDirection.val == paramInt)
		  {
			return localDirection;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<Direction> values()
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

		public static Direction valueOf(string name)
		{
			foreach (Direction enumInstance in Direction.values())
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