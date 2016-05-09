namespace org.openni
{

	public class Recorder : ProductionNode
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: Recorder(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  internal Recorder(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Recorder create(Context paramContext, String paramString) throws GeneralException
	  public static Recorder create(Context paramContext, string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateRecorder(paramContext.toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		Recorder localRecorder = (Recorder)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.RECORDER);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localRecorder;
	  }

	  public virtual string Format
	  {
		  get
		  {
			return NativeMethods.xnGetRecorderFormat(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setDestination(RecordMedium paramRecordMedium, String paramString) throws StatusException
	  public virtual void setDestination(RecordMedium paramRecordMedium, string paramString)
	  {
		int i = NativeMethods.xnSetRecorderDestination(toNative(), paramRecordMedium.toNative(), paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public RecordMedium getDestinationMedium() throws StatusException
	  public virtual RecordMedium DestinationMedium
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			int i = NativeMethods.xnGetRecorderDestination(toNative(), localOutArg1, localOutArg2);
			WrapperUtils.throwOnError(i);
			return RecordMedium.fromNative(((int?)localOutArg1.value).Value);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getDestination() throws StatusException
	  public virtual string Destination
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			int i = NativeMethods.xnGetRecorderDestination(toNative(), localOutArg1, localOutArg2);
			WrapperUtils.throwOnError(i);
			return (string)localOutArg2.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addNodeToRecording(ProductionNode paramProductionNode, CodecID paramCodecID) throws StatusException
	  public virtual void addNodeToRecording(ProductionNode paramProductionNode, CodecID paramCodecID)
	  {
		int i = NativeMethods.xnAddNodeToRecording(toNative(), paramProductionNode.toNative(), paramCodecID.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addNodeToRecording(ProductionNode paramProductionNode) throws StatusException
	  public virtual void addNodeToRecording(ProductionNode paramProductionNode)
	  {
		addNodeToRecording(paramProductionNode, CodecID.Null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void removeNodeToRecording(ProductionNode paramProductionNode) throws StatusException
	  public virtual void removeNodeToRecording(ProductionNode paramProductionNode)
	  {
		int i = NativeMethods.xnRemoveNodeFromRecording(toNative(), paramProductionNode.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void Record() throws StatusException
	  public virtual void Record()
	  {
		int i = NativeMethods.xnRecord(toNative());
		WrapperUtils.throwOnError(i);
	  }
	}

}