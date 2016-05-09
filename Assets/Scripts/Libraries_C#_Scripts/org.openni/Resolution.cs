using System.Collections.Generic;

namespace org.openni
{

	public sealed class Resolution
	{
	  public static readonly Resolution CUSTOM = new Resolution("CUSTOM", InnerEnum.CUSTOM, 0);
	  public static readonly Resolution QQVGA = new Resolution("QQVGA", InnerEnum.QQVGA, 1);
	  public static readonly Resolution CGA = new Resolution("CGA", InnerEnum.CGA, 2);
	  public static readonly Resolution QVGA = new Resolution("QVGA", InnerEnum.QVGA, 3);
	  public static readonly Resolution VGA = new Resolution("VGA", InnerEnum.VGA, 4);
	  public static readonly Resolution SVGA = new Resolution("SVGA", InnerEnum.SVGA, 5);
	  public static readonly Resolution XGA = new Resolution("XGA", InnerEnum.XGA, 6);
	  public static readonly Resolution P720 = new Resolution("P720", InnerEnum.P720, 7);
	  public static readonly Resolution SXGA = new Resolution("SXGA", InnerEnum.SXGA, 8);
	  public static readonly Resolution UXGA = new Resolution("UXGA", InnerEnum.UXGA, 9);
	  public static readonly Resolution P1080 = new Resolution("P1080", InnerEnum.P1080, 10);

	  private static readonly IList<Resolution> valueList = new List<Resolution>();

	  static Resolution()
	  {
		  valueList.Add(CUSTOM);
		  valueList.Add(QQVGA);
		  valueList.Add(CGA);
		  valueList.Add(QVGA);
		  valueList.Add(VGA);
		  valueList.Add(SVGA);
		  valueList.Add(XGA);
		  valueList.Add(P720);
		  valueList.Add(SXGA);
		  valueList.Add(UXGA);
		  valueList.Add(P1080);
	  }

	  public enum InnerEnum
	  {
		  CUSTOM,
		  QQVGA,
		  CGA,
		  QVGA,
		  VGA,
		  SVGA,
		  XGA,
		  P720,
		  SXGA,
		  UXGA,
		  P1080
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private readonly int val;
	  private readonly int xRes;
	  private readonly int yRes;
	  private readonly string name;

	  private Resolution(string name, InnerEnum innerEnum, int paramInt)
	  {
		this.val = paramInt;
		this.xRes = NativeMethods.xnResolutionGetXRes(paramInt);
		this.yRes = NativeMethods.xnResolutionGetYRes(paramInt);
		this.name = NativeMethods.xnResolutionGetName(paramInt);

		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  public int getxRes()
	  {
		return this.xRes;
	  }

	  public int getyRes()
	  {
		return this.yRes;
	  }

	  public string Name
	  {
		  get
		  {
			return this.name;
		  }
	  }

	  public int toNative()
	  {
		return this.val;
	  }

	  public static Resolution fromNative(int paramInt)
	  {
		foreach (Resolution localResolution in)
		{
		  if (localResolution.val == paramInt)
		  {
			return localResolution;
		  }
		}
		throw new NoSuchElementException();
	  }

	  public static Resolution fromName(string paramString)
	  {
		return fromNative(NativeMethods.xnResolutionGetFromName(paramString));
	  }

	  public static Resolution fromXYRes(int paramInt1, int paramInt2)
	  {
		return fromNative(NativeMethods.xnResolutionGetFromXYRes(paramInt1, paramInt2));
	  }

		public static IList<Resolution> values()
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

		public static Resolution valueOf(string name)
		{
			foreach (Resolution enumInstance in Resolution.values())
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