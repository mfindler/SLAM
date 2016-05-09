namespace org.openni
{

	public class ProductionNode : NodeWrapper
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: ProductionNode(Context paramContext, long paramLong, boolean paramBoolean) throws StatusException
	  internal ProductionNode(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static ProductionNode fromNative(long paramLong) throws GeneralException
	  public static ProductionNode fromNative(long paramLong)
	  {
		return Context.createProductionNodeFromNative(paramLong);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfo getInfo() throws GeneralException
	  public virtual NodeInfo Info
	  {
		  get
		  {
			return new NodeInfo(NativeMethods.xnGetNodeInfo(toNative()));
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addNeededNode(ProductionNode paramProductionNode) throws StatusException
	  public virtual void addNeededNode(ProductionNode paramProductionNode)
	  {
		int i = NativeMethods.xnAddNeededNode(toNative(), paramProductionNode.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void removeNeededNode(ProductionNode paramProductionNode) throws StatusException
	  public virtual void removeNeededNode(ProductionNode paramProductionNode)
	  {
		int i = NativeMethods.xnRemoveNeededNode(toNative(), paramProductionNode.toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool isCapabilitySupported(string paramString)
	  {
		return NativeMethods.xnIsCapabilitySupported(toNative(), paramString);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setIntProperty(String paramString, long paramLong) throws StatusException
	  public virtual void setIntProperty(string paramString, long paramLong)
	  {
		int i = NativeMethods.xnSetIntProperty(toNative(), paramString, paramLong);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setRealProperty(String paramString, double paramDouble) throws StatusException
	  public virtual void setRealProperty(string paramString, double paramDouble)
	  {
		int i = NativeMethods.xnSetRealProperty(toNative(), paramString, paramDouble);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setStringProperty(String paramString1, String paramString2) throws StatusException
	  public virtual void setStringProperty(string paramString1, string paramString2)
	  {
		int i = NativeMethods.xnSetStringProperty(toNative(), paramString1, paramString2);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setGeneralProperty(String paramString, int paramInt, long paramLong) throws StatusException
	  public virtual void setGeneralProperty(string paramString, int paramInt, long paramLong)
	  {
		int i = NativeMethods.xnSetGeneralProperty(toNative(), paramString, paramInt, paramLong);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setGeneralProperty(String paramString, byte[] paramArrayOfByte) throws StatusException
	  public virtual void setGeneralProperty(string paramString, sbyte[] paramArrayOfByte)
	  {
		int i = NativeMethods.xnSetGeneralPropertyArray(toNative(), paramString, paramArrayOfByte);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public long getIntProperty(String paramString) throws StatusException
	  public virtual long getIntProperty(string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetIntProperty(toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		return ((long?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public double getRealProperty(String paramString) throws StatusException
	  public virtual double getRealProperty(string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetRealProperty(toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		return ((double?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getStringProperty(String paramString) throws StatusException
	  public virtual string getStringProperty(string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetStringProperty(toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		return (string)localOutArg.value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void getGeneralProperty(String paramString, int paramInt, long paramLong) throws StatusException
	  public virtual void getGeneralProperty(string paramString, int paramInt, long paramLong)
	  {
		int i = NativeMethods.xnGetGeneralProperty(toNative(), paramString, paramInt, paramLong);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void getGeneralProperty(String paramString, byte[] paramArrayOfByte) throws StatusException
	  public virtual void getGeneralProperty(string paramString, sbyte[] paramArrayOfByte)
	  {
		int i = NativeMethods.xnGetGeneralPropertyArray(toNative(), paramString, paramArrayOfByte);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public LockHandle lockForChanges() throws StatusException
	  public virtual LockHandle lockForChanges()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnLockNodeForChanges(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return new LockHandle(((int?)localOutArg.value).Value);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void unlockForChanges(LockHandle paramLockHandle) throws StatusException
	  public virtual void unlockForChanges(LockHandle paramLockHandle)
	  {
		int i = NativeMethods.xnUnlockNodeForChanges(toNative(), paramLockHandle.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void lockedNodeStartChanges(LockHandle paramLockHandle) throws StatusException
	  public virtual void lockedNodeStartChanges(LockHandle paramLockHandle)
	  {
		int i = NativeMethods.xnLockedNodeStartChanges(toNative(), paramLockHandle.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void lockedNodeEndChanges(LockHandle paramLockHandle) throws StatusException
	  public virtual void lockedNodeEndChanges(LockHandle paramLockHandle)
	  {
		int i = NativeMethods.xnLockedNodeEndChanges(toNative(), paramLockHandle.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ErrorStateCapability getErrorStateCapability() throws StatusException
	  public virtual ErrorStateCapability ErrorStateCapability
	  {
		  get
		  {
			return new ErrorStateCapability(this);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability getGeneralIntCapability(Capability paramCapability) throws StatusException
	  public virtual GeneralIntCapability getGeneralIntCapability(Capability paramCapability)
	  {
		return new GeneralIntCapability(this, paramCapability);
	  }
	}

}