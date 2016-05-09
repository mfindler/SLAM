using System.Collections.Generic;

namespace org.openni
{

	public sealed class PowerLineFrequency
	{
	  public static readonly PowerLineFrequency OFF = new PowerLineFrequency("OFF", InnerEnum.OFF, 0);
	  public static readonly PowerLineFrequency HZ50 = new PowerLineFrequency("HZ50", InnerEnum.HZ50, 50);
	  public static readonly PowerLineFrequency HZ60 = new PowerLineFrequency("HZ60", InnerEnum.HZ60, 60);

	  private static readonly IList<PowerLineFrequency> valueList = new List<PowerLineFrequency>();

	  static PowerLineFrequency()
	  {
		  valueList.Add(OFF);
		  valueList.Add(HZ50);
		  valueList.Add(HZ60);
	  }

	  public enum InnerEnum
	  {
		  OFF,
		  HZ50,
		  HZ60
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private PowerLineFrequency(string name, InnerEnum innerEnum, int paramInt)
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

	  public static PowerLineFrequency fromNative(int paramInt)
	  {
		foreach (PowerLineFrequency localPowerLineFrequency in)
		{
		  if (localPowerLineFrequency.val == paramInt)
		  {
			return localPowerLineFrequency;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<PowerLineFrequency> values()
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

		public static PowerLineFrequency valueOf(string name)
		{
			foreach (PowerLineFrequency enumInstance in PowerLineFrequency.values())
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