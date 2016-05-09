using System.Collections.Generic;

namespace org.openni
{

	public sealed class RecordMedium
	{
	  public static readonly RecordMedium FILE = new RecordMedium("FILE", InnerEnum.FILE, 0);

	  private static readonly IList<RecordMedium> valueList = new List<RecordMedium>();

	  static RecordMedium()
	  {
		  valueList.Add(FILE);
	  }

	  public enum InnerEnum
	  {
		  FILE
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;

	  private RecordMedium(string name, InnerEnum innerEnum, int paramInt)
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

	  public static RecordMedium fromNative(int paramInt)
	  {
		foreach (RecordMedium localRecordMedium in)
		{
		  if (localRecordMedium.val == paramInt)
		  {
			return localRecordMedium;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<RecordMedium> values()
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

		public static RecordMedium valueOf(string name)
		{
			foreach (RecordMedium enumInstance in RecordMedium.values())
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