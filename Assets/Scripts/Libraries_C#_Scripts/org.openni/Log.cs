using System.Collections.Generic;

namespace org.openni
{

	public class Log
	{
	  public sealed class Severity
	  {
		public static readonly Severity VERBOSE = new Severity("VERBOSE", InnerEnum.VERBOSE, 0);
		public static readonly Severity INFO = new Severity("INFO", InnerEnum.INFO, 1);
		public static readonly Severity WARNING = new Severity("WARNING", InnerEnum.WARNING, 2);
		public static readonly Severity ERROR = new Severity("ERROR", InnerEnum.ERROR, 3);

		private static readonly IList<Severity> valueList = new List<Severity>();

		static Severity()
		{
			valueList.Add(VERBOSE);
			valueList.Add(INFO);
			valueList.Add(WARNING);
			valueList.Add(ERROR);
		}

		public enum InnerEnum
		{
			VERBOSE,
			INFO,
			WARNING,
			ERROR
		}

		private readonly string nameValue;
		private readonly int ordinalValue;
		private readonly InnerEnum innerEnumValue;
		private static int nextOrdinal = 0;

		internal int val;

		internal Severity(string name, InnerEnum innerEnum, int paramInt)
		{
		  this.val = paramInt;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}

		public int Value
		{
			get
			{
			  return this.val;
			}
		}

		  public static IList<Severity> values()
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

		  public static Severity valueOf(string name)
		  {
			  foreach (Severity enumInstance in Severity.values())
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

}