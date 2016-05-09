namespace org.openni
{

	public class MapGenerator : Generator
	{
	  private StateChangedObservable mapOutputModeChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: MapGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal MapGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.mapOutputModeChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly MapGenerator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(MapGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToMapOutputModeChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromMapOutputModeChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public MapOutputMode[] getSupportedMapOutputModes() throws StatusException
	  public virtual MapOutputMode[] SupportedMapOutputModes
	  {
		  get
		  {
			int i = NativeMethods.xnGetSupportedMapOutputModesCount(toNative());
			MapOutputMode[] arrayOfMapOutputMode = new MapOutputMode[i];
			int j = NativeMethods.xnGetSupportedMapOutputModes(toNative(), arrayOfMapOutputMode);
			WrapperUtils.throwOnError(j);
			return arrayOfMapOutputMode;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public MapOutputMode getMapOutputMode() throws StatusException
	  public virtual MapOutputMode MapOutputMode
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			OutArg localOutArg3 = new OutArg();
			int i = NativeMethods.xnGetMapOutputMode(toNative(), localOutArg1, localOutArg2, localOutArg3);
			WrapperUtils.throwOnError(i);
			return new MapOutputMode(((int?)localOutArg1.value).Value, ((int?)localOutArg2.value).Value, ((int?)localOutArg3.value).Value);
		  }
		  set
		  {
			int i = NativeMethods.xnSetMapOutputMode(toNative(), value.XRes, value.YRes, value.FPS);
			WrapperUtils.throwOnError(i);
		  }
	  }


	  public virtual IStateChangedObservable MapOutputModeChangedEvent
	  {
		  get
		  {
			return this.mapOutputModeChanged;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public CroppingCapability getCroppingCapability() throws StatusException
	  public virtual CroppingCapability CroppingCapability
	  {
		  get
		  {
			return new CroppingCapability(this);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getBrightnessCapability() throws StatusException
	  public virtual GeneralIntCapability BrightnessCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Brightness);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getContrastCapability() throws StatusException
	  public virtual GeneralIntCapability ContrastCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Contrast);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getSaturationCapability() throws StatusException
	  public virtual GeneralIntCapability SaturationCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Saturation);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getHueCapability() throws StatusException
	  public virtual GeneralIntCapability HueCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Hue);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getSharpnessCapability() throws StatusException
	  public virtual GeneralIntCapability SharpnessCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Sharpness);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getGammaCapability() throws StatusException
	  public virtual GeneralIntCapability GammaCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Gamma);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getWhiteBalanceCapability() throws StatusException
	  public virtual GeneralIntCapability WhiteBalanceCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.WhiteBalance);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getBacklightCompensationCapability() throws StatusException
	  public virtual GeneralIntCapability BacklightCompensationCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.BacklightCompensation);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getGainCapability() throws StatusException
	  public virtual GeneralIntCapability GainCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Gain);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getPanCapability() throws StatusException
	  public virtual GeneralIntCapability PanCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Pan);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getTiltCapability() throws StatusException
	  public virtual GeneralIntCapability TiltCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Tilt);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getRollCapability() throws StatusException
	  public virtual GeneralIntCapability RollCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Roll);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getZoomCapability() throws StatusException
	  public virtual GeneralIntCapability ZoomCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Zoom);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getExposureCapability() throws StatusException
	  public virtual GeneralIntCapability ExposureCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Exposure);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getIrisCapability() throws StatusException
	  public virtual GeneralIntCapability IrisCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Iris);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getFocusCapability() throws StatusException
	  public virtual GeneralIntCapability FocusCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.Focus);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getLowLightCompensationCapability() throws StatusException
	  public virtual GeneralIntCapability LowLightCompensationCapability
	  {
		  get
		  {
			return new GeneralIntCapability(this, Capability.LowLightCompensation);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public AntiFlickerCapability getAntiFlickerCapability() throws StatusException
	  public virtual AntiFlickerCapability AntiFlickerCapability
	  {
		  get
		  {
			return new AntiFlickerCapability(this);
		  }
	  }
	}

}