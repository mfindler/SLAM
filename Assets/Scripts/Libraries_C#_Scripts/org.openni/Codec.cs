namespace org.openni
{

	public class Codec : ProductionNode
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: Codec(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  internal Codec(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Codec create(Context paramContext, CodecID paramCodecID, ProductionNode paramProductionNode) throws GeneralException
	  public static Codec create(Context paramContext, CodecID paramCodecID, ProductionNode paramProductionNode)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateCodec(paramContext.toNative(), paramCodecID.toNative(), paramProductionNode.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		Codec localCodec = (Codec)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.CODEC);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localCodec;
	  }

	  public virtual CodecID CodecID
	  {
		  get
		  {
			int i = NativeMethods.xnGetCodecID(toNative());
			return new CodecID(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int EncodeData(long paramLong1, int paramInt1, long paramLong2, int paramInt2) throws StatusException
	  public virtual int EncodeData(long paramLong1, int paramInt1, long paramLong2, int paramInt2)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEncodeData(toNative(), paramLong1, paramInt1, paramLong2, paramInt2, localOutArg);
		WrapperUtils.throwOnError(i);
		return ((int?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int DecodeData(long paramLong1, int paramInt1, long paramLong2, int paramInt2) throws StatusException
	  public virtual int DecodeData(long paramLong1, int paramInt1, long paramLong2, int paramInt2)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnDecodeData(toNative(), paramLong1, paramInt1, paramLong2, paramInt2, localOutArg);
		WrapperUtils.throwOnError(i);
		return ((int?)localOutArg.value).Value;
	  }
	}

}