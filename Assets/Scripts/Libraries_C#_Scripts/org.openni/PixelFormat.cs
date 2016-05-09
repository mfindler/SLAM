using System.Collections.Generic;

namespace org.openni
{

	public sealed class PixelFormat
	{
	  public static readonly PixelFormat RGB24 = new PixelFormat("RGB24", InnerEnum.RGB24, 1);
	  public static readonly PixelFormat YUV422 = new PixelFormat("YUV422", InnerEnum.YUV422, 2);
	  public static readonly PixelFormat GRAYSCALE_8BIT = new PixelFormat("GRAYSCALE_8BIT", InnerEnum.GRAYSCALE_8BIT, 3);
	  public static readonly PixelFormat GRAYSCALE_16BIT = new PixelFormat("GRAYSCALE_16BIT", InnerEnum.GRAYSCALE_16BIT, 4);

	  private static readonly IList<PixelFormat> valueList = new List<PixelFormat>();

	  static PixelFormat()
	  {
		  valueList.Add(RGB24);
		  valueList.Add(YUV422);
		  valueList.Add(GRAYSCALE_8BIT);
		  valueList.Add(GRAYSCALE_16BIT);
	  }

	  public enum InnerEnum
	  {
		  RGB24,
		  YUV422,
		  GRAYSCALE_8BIT,
		  GRAYSCALE_16BIT
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private int val;

	  private PixelFormat(string name, InnerEnum innerEnum, int paramInt)
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

	  public int BytesPerPixel
	  {
		  get
		  {
			return NativeMethods.xnGetBytesPerPixelForPixelFormat(this.val);
		  }
	  }

	  public static PixelFormat fromNative(int paramInt)
	  {
		foreach (PixelFormat localPixelFormat in)
		{
		  if (localPixelFormat.val == paramInt)
		  {
			return localPixelFormat;
		  }
		}
		throw new NoSuchElementException();
	  }

		public static IList<PixelFormat> values()
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

		public static PixelFormat valueOf(string name)
		{
			foreach (PixelFormat enumInstance in PixelFormat.values())
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