namespace org.openni
{

	public class Generator : ProductionNode
	{
	  private StateChangedObservable generationRunningChanged;
	  private StateChangedObservable newDataAvailable;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: Generator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal Generator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.generationRunningChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
		this.newDataAvailable = new StateChangedObservableAnonymousInnerClassHelper2(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly Generator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(Generator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToGenerationRunningChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromGenerationRunningChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper2 : StateChangedObservable
	  {
		  private readonly Generator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper2(Generator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToNewDataAvailable(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromNewDataAvailable(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void startGenerating() throws StatusException
	  public virtual void startGenerating()
	  {
		int i = NativeMethods.xnStartGenerating(toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool Generating
	  {
		  get
		  {
			return NativeMethods.xnIsGenerating(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void stopGenerating() throws StatusException
	  public virtual void stopGenerating()
	  {
		int i = NativeMethods.xnStopGenerating(toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual IStateChangedObservable GenerationRunningChangedEvent
	  {
		  get
		  {
			return this.generationRunningChanged;
		  }
	  }

	  public virtual bool NewDataAvailable
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			return NativeMethods.xnIsNewDataAvailable(toNative(), localOutArg);
		  }
	  }

	  public virtual long AvailableTimestamp
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			NativeMethods.xnIsNewDataAvailable(toNative(), localOutArg);
			return ((long?)localOutArg.value).Value;
		  }
	  }

	  public virtual IStateChangedObservable NewDataAvailableEvent
	  {
		  get
		  {
			return this.newDataAvailable;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void waitAndUpdateData() throws StatusException
	  public virtual void waitAndUpdateData()
	  {
		int i = NativeMethods.xnWaitAndUpdateData(toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool DataNew
	  {
		  get
		  {
			return NativeMethods.xnIsDataNew(toNative());
		  }
	  }

	  public virtual int DataSize
	  {
		  get
		  {
			return NativeMethods.xnGetDataSize(toNative());
		  }
	  }

	  public virtual long DataPtr
	  {
		  get
		  {
			return NativeMethods.xnGetData(toNative());
		  }
	  }

	  public virtual ByteBuffer createDataByteBuffer()
	  {
		int i = DataSize;
		ByteBuffer localByteBuffer = ByteBuffer.allocateDirect(i);
		localByteBuffer.order(ByteOrder.LITTLE_ENDIAN);
		NativeMethods.copyToBuffer(localByteBuffer, DataPtr, i);
		return localByteBuffer;
	  }

	  public virtual void copyDataToBuffer(ByteBuffer paramByteBuffer, int paramInt)
	  {
		NativeMethods.copyToBuffer(paramByteBuffer, DataPtr, paramInt);
	  }

	  public virtual long Timestamp
	  {
		  get
		  {
			return NativeMethods.xnGetTimestamp(toNative());
		  }
	  }

	  public virtual int FrameID
	  {
		  get
		  {
			return NativeMethods.xnGetFrameID(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public MirrorCapability getMirrorCapability() throws StatusException
	  public virtual MirrorCapability MirrorCapability
	  {
		  get
		  {
			return new MirrorCapability(this);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public AlternativeViewpointCapability getAlternativeViewpointCapability() throws StatusException
	  public virtual AlternativeViewpointCapability AlternativeViewpointCapability
	  {
		  get
		  {
			return new AlternativeViewpointCapability(this);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public FrameSyncCapability getFrameSyncCapability() throws StatusException
	  public virtual FrameSyncCapability FrameSyncCapability
	  {
		  get
		  {
			return new FrameSyncCapability(this);
		  }
	  }
	}

}