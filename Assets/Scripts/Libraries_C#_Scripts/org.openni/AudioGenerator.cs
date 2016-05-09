namespace org.openni
{

	public class AudioGenerator : Generator
	{
	  private StateChangedObservable waveOutputModeChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public AudioGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  public AudioGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.waveOutputModeChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly AudioGenerator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(AudioGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToWaveOutputModeChanges(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromWaveOutputModeChanges(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static AudioGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static AudioGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateAudioGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		AudioGenerator localAudioGenerator = (AudioGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.AUDIO);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localAudioGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static AudioGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static AudioGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static AudioGenerator create(Context paramContext) throws GeneralException
	  public static AudioGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public WaveOutputMode[] getSupportedMapOutputModes() throws StatusException
	  public virtual WaveOutputMode[] SupportedMapOutputModes
	  {
		  get
		  {
			int i = NativeMethods.xnGetSupportedWaveOutputModesCount(toNative());
			WaveOutputMode[] arrayOfWaveOutputMode = new WaveOutputMode[i];
			int j = NativeMethods.xnGetSupportedWaveOutputModes(toNative(), arrayOfWaveOutputMode);
			WrapperUtils.throwOnError(j);
			return arrayOfWaveOutputMode;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public WaveOutputMode getWaveOutputMode() throws StatusException
	  public virtual WaveOutputMode WaveOutputMode
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			OutArg localOutArg3 = new OutArg();
			int i = NativeMethods.xnGetWaveOutputMode(toNative(), localOutArg1, localOutArg2, localOutArg3);
			WrapperUtils.throwOnError(i);
			return new WaveOutputMode(((int?)localOutArg1.value).Value, ((short?)localOutArg2.value).Value, ((sbyte?)localOutArg3.value).Value);
		  }
		  set
		  {
			int i = NativeMethods.xnSetWaveOutputMode(toNative(), value.SampleRate, value.BitsPerSample, value.NumberOfChannels);
			WrapperUtils.throwOnError(i);
		  }
	  }


	  public virtual IStateChangedObservable MapOutputModeChangedEvent
	  {
		  get
		  {
			return this.waveOutputModeChanged;
		  }
	  }

	  public virtual void getMetaData(AudioMetaData paramAudioMetaData)
	  {
		NativeMethods.xnGetAudioMetaData(toNative(), paramAudioMetaData);
	  }

	  public virtual AudioMetaData MetaData
	  {
		  get
		  {
			AudioMetaData localAudioMetaData = new AudioMetaData();
			getMetaData(localAudioMetaData);
			return localAudioMetaData;
		  }
	  }
	}

}