using System.Collections.Generic;

namespace org.openni
{

	public sealed class Capability
	{
	  public static readonly Capability ExtendedSerialization = new Capability("ExtendedSerialization", InnerEnum.ExtendedSerialization, "ExtendedSerialization");
	  public static readonly Capability Mirror = new Capability("Mirror", InnerEnum.Mirror, "Mirror");
	  public static readonly Capability AlternativeViewPoint = new Capability("AlternativeViewPoint", InnerEnum.AlternativeViewPoint, "AlternativeViewPoint");
	  public static readonly Capability Cropping = new Capability("Cropping", InnerEnum.Cropping, "Cropping");
	  public static readonly Capability UserPosition = new Capability("UserPosition", InnerEnum.UserPosition, "UserPosition");
	  public static readonly Capability Skeleton = new Capability("Skeleton", InnerEnum.Skeleton, "User::Skeleton");
	  public static readonly Capability PoseDetection = new Capability("PoseDetection", InnerEnum.PoseDetection, "User::PoseDetection");
	  public static readonly Capability LockAware = new Capability("LockAware", InnerEnum.LockAware, "LockAware");
	  public static readonly Capability ErrorState = new Capability("ErrorState", InnerEnum.ErrorState, "ErrorState");
	  public static readonly Capability FrameSync = new Capability("FrameSync", InnerEnum.FrameSync, "FrameSync");
	  public static readonly Capability DeviceIdentification = new Capability("DeviceIdentification", InnerEnum.DeviceIdentification, "DeviceIdentification");
	  public static readonly Capability Brightness = new Capability("Brightness", InnerEnum.Brightness, "Brightness");
	  public static readonly Capability Contrast = new Capability("Contrast", InnerEnum.Contrast, "Contrast");
	  public static readonly Capability Hue = new Capability("Hue", InnerEnum.Hue, "Hue");
	  public static readonly Capability Saturation = new Capability("Saturation", InnerEnum.Saturation, "Saturation");
	  public static readonly Capability Sharpness = new Capability("Sharpness", InnerEnum.Sharpness, "Sharpness");
	  public static readonly Capability Gamma = new Capability("Gamma", InnerEnum.Gamma, "Gamma");
	  public static readonly Capability WhiteBalance = new Capability("WhiteBalance", InnerEnum.WhiteBalance, "ColorTemperature");
	  public static readonly Capability BacklightCompensation = new Capability("BacklightCompensation", InnerEnum.BacklightCompensation, "BacklightCompensation");
	  public static readonly Capability Gain = new Capability("Gain", InnerEnum.Gain, "Gain");
	  public static readonly Capability Pan = new Capability("Pan", InnerEnum.Pan, "Pan");
	  public static readonly Capability Tilt = new Capability("Tilt", InnerEnum.Tilt, "Tilt");
	  public static readonly Capability Roll = new Capability("Roll", InnerEnum.Roll, "Roll");
	  public static readonly Capability Zoom = new Capability("Zoom", InnerEnum.Zoom, "Zoom");
	  public static readonly Capability Exposure = new Capability("Exposure", InnerEnum.Exposure, "Exposure");
	  public static readonly Capability Iris = new Capability("Iris", InnerEnum.Iris, "Iris");
	  public static readonly Capability Focus = new Capability("Focus", InnerEnum.Focus, "Focus");
	  public static readonly Capability LowLightCompensation = new Capability("LowLightCompensation", InnerEnum.LowLightCompensation, "LowLightCompensation");
	  public static readonly Capability AntiFlicker = new Capability("AntiFlicker", InnerEnum.AntiFlicker, "AntiFlicker");

	  private static readonly IList<Capability> valueList = new List<Capability>();

	  static Capability()
	  {
		  valueList.Add(ExtendedSerialization);
		  valueList.Add(Mirror);
		  valueList.Add(AlternativeViewPoint);
		  valueList.Add(Cropping);
		  valueList.Add(UserPosition);
		  valueList.Add(Skeleton);
		  valueList.Add(PoseDetection);
		  valueList.Add(LockAware);
		  valueList.Add(ErrorState);
		  valueList.Add(FrameSync);
		  valueList.Add(DeviceIdentification);
		  valueList.Add(Brightness);
		  valueList.Add(Contrast);
		  valueList.Add(Hue);
		  valueList.Add(Saturation);
		  valueList.Add(Sharpness);
		  valueList.Add(Gamma);
		  valueList.Add(WhiteBalance);
		  valueList.Add(BacklightCompensation);
		  valueList.Add(Gain);
		  valueList.Add(Pan);
		  valueList.Add(Tilt);
		  valueList.Add(Roll);
		  valueList.Add(Zoom);
		  valueList.Add(Exposure);
		  valueList.Add(Iris);
		  valueList.Add(Focus);
		  valueList.Add(LowLightCompensation);
		  valueList.Add(AntiFlicker);
	  }

	  public enum InnerEnum
	  {
		  ExtendedSerialization,
		  Mirror,
		  AlternativeViewPoint,
		  Cropping,
		  UserPosition,
		  Skeleton,
		  PoseDetection,
		  LockAware,
		  ErrorState,
		  FrameSync,
		  DeviceIdentification,
		  Brightness,
		  Contrast,
		  Hue,
		  Saturation,
		  Sharpness,
		  Gamma,
		  WhiteBalance,
		  BacklightCompensation,
		  Gain,
		  Pan,
		  Tilt,
		  Roll,
		  Zoom,
		  Exposure,
		  Iris,
		  Focus,
		  LowLightCompensation,
		  AntiFlicker
	  }

	  private readonly string nameValue;
	  private readonly int ordinalValue;
	  private readonly InnerEnum innerEnumValue;
	  private static int nextOrdinal = 0;

	  private string name;

	  private Capability(string name, InnerEnum innerEnum, string paramString)
	  {
		this.name = paramString;

		  nameValue = name;
		  ordinalValue = nextOrdinal++;
		  innerEnumValue = innerEnum;
	  }

	  public string Name
	  {
		  get
		  {
			return this.name;
		  }
	  }

		public static IList<Capability> values()
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

		public static Capability valueOf(string name)
		{
			foreach (Capability enumInstance in Capability.values())
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