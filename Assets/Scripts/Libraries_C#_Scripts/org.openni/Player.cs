namespace org.openni
{

	public class Player : ProductionNode
	{
	  private StateChangedObservable eofReached;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: Player(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  internal Player(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.eofReached = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly Player outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(Player outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToEndOfFileReached(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromEndOfFileReached(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Player create(Context paramContext, String paramString) throws GeneralException
	  public static Player create(Context paramContext, string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreatePlayer(paramContext.toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		Player localPlayer = (Player)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.PLAYER);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localPlayer;
	  }

	  public virtual string Format
	  {
		  get
		  {
			return NativeMethods.xnGetPlayerSupportedFormat(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setSource(RecordMedium paramRecordMedium, String paramString) throws StatusException
	  public virtual void setSource(RecordMedium paramRecordMedium, string paramString)
	  {
		int i = NativeMethods.xnSetPlayerSource(toNative(), paramRecordMedium.toNative(), paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public RecordMedium getSourceMedium() throws StatusException
	  public virtual RecordMedium SourceMedium
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			int i = NativeMethods.xnGetPlayerSource(toNative(), localOutArg1, localOutArg2);
			WrapperUtils.throwOnError(i);
			return RecordMedium.fromNative(((int?)localOutArg1.value).Value);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getSource() throws StatusException
	  public virtual string Source
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			int i = NativeMethods.xnGetPlayerSource(toNative(), localOutArg1, localOutArg2);
			WrapperUtils.throwOnError(i);
			return (string)localOutArg2.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setRepeat(boolean paramBoolean) throws StatusException
	  public virtual bool Repeat
	  {
		  set
		  {
			int i = NativeMethods.xnSetPlayerRepeat(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void readNext() throws StatusException
	  public virtual void readNext()
	  {
		int i = NativeMethods.xnPlayerReadNext(toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void seekToTimestamp(PlayerSeekOrigin paramPlayerSeekOrigin, long paramLong) throws StatusException
	  public virtual void seekToTimestamp(PlayerSeekOrigin paramPlayerSeekOrigin, long paramLong)
	  {
		int i = NativeMethods.xnSeekPlayerToTimeStamp(toNative(), paramLong, paramPlayerSeekOrigin.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void seekToFrame(ProductionNode paramProductionNode, PlayerSeekOrigin paramPlayerSeekOrigin, int paramInt) throws StatusException
	  public virtual void seekToFrame(ProductionNode paramProductionNode, PlayerSeekOrigin paramPlayerSeekOrigin, int paramInt)
	  {
		int i = NativeMethods.xnSeekPlayerToFrame(toNative(), paramProductionNode.Name, paramInt, paramPlayerSeekOrigin.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public long tellTimestamp() throws StatusException
	  public virtual long tellTimestamp()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnTellPlayerTimestamp(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return ((long?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int tellFrame(ProductionNode paramProductionNode) throws StatusException
	  public virtual int tellFrame(ProductionNode paramProductionNode)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnTellPlayerFrame(toNative(), paramProductionNode.Name, localOutArg);
		WrapperUtils.throwOnError(i);
		return ((int?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int getNumberOfFrames(ProductionNode paramProductionNode) throws StatusException
	  public virtual int getNumberOfFrames(ProductionNode paramProductionNode)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetPlayerNumFrames(toNative(), paramProductionNode.Name, localOutArg);
		WrapperUtils.throwOnError(i);
		return ((int?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfoList enumerateNodes() throws StatusException
	  public virtual NodeInfoList enumerateNodes()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumeratePlayerNodes(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return new NodeInfoList(((long?)localOutArg.value).Value);
	  }

	  public virtual bool EOF
	  {
		  get
		  {
			return NativeMethods.xnIsPlayerAtEOF(toNative());
		  }
	  }

	  public virtual IStateChangedObservable EOFReachedEvent
	  {
		  get
		  {
			return this.eofReached;
		  }
	  }

	  public virtual double PlaybackSpeed
	  {
		  get
		  {
			return NativeMethods.xnGetPlaybackSpeed(toNative());
		  }
		  set
		  {
			int i = NativeMethods.xnSetPlaybackSpeed(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

	}

}