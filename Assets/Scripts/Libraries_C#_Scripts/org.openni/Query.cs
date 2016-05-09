namespace org.openni
{

	public class Query : ObjectWrapper
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Query() throws GeneralException
	  public Query() : base(allocate())
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setVendor(String paramString) throws StatusException
	  public virtual string Vendor
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetVendor(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setName(String paramString) throws StatusException
	  public virtual string Name
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetName(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setMinVersion(Version paramVersion) throws StatusException
	  public virtual Version MinVersion
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetMinVersion(toNative(), value.Major, value.Minor, value.Maintenance, value.Build);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setMaxVersion(Version paramVersion) throws StatusException
	  public virtual Version MaxVersion
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetMaxVersion(toNative(), value.Major, value.Minor, value.Maintenance, value.Build);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addSupportedCapability(Capability paramCapability) throws StatusException
	  public virtual void addSupportedCapability(Capability paramCapability)
	  {
		int i = NativeMethods.xnNodeQueryAddSupportedCapability(toNative(), paramCapability.Name);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addSupportedMapOutputMode(MapOutputMode paramMapOutputMode) throws StatusException
	  public virtual void addSupportedMapOutputMode(MapOutputMode paramMapOutputMode)
	  {
		int i = NativeMethods.xnNodeQueryAddSupportedMapOutputMode(toNative(), paramMapOutputMode.XRes, paramMapOutputMode.YRes, paramMapOutputMode.FPS);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addSupportedMinUserPositions(int paramInt) throws StatusException
	  public virtual void addSupportedMinUserPositions(int paramInt)
	  {
		int i = NativeMethods.xnNodeQuerySetSupportedMinUserPositions(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setExistingNodeOnly(boolean paramBoolean) throws StatusException
	  public virtual bool ExistingNodeOnly
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetExistingNodeOnly(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setNonExistingNodeOnly(boolean paramBoolean) throws StatusException
	  public virtual bool NonExistingNodeOnly
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetNonExistingNodeOnly(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addNeededNode(ProductionNode paramProductionNode) throws StatusException
	  public virtual void addNeededNode(ProductionNode paramProductionNode)
	  {
		int i = NativeMethods.xnNodeQueryAddNeededNode(toNative(), paramProductionNode.Name);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setCreationInfo(String paramString) throws StatusException
	  public virtual string CreationInfo
	  {
		  set
		  {
			int i = NativeMethods.xnNodeQuerySetCreationInfo(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

	  protected internal virtual void freeObject(long paramLong)
	  {
		NativeMethods.xnNodeQueryFree(paramLong);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private static long allocate() throws StatusException
	  private static long allocate()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnNodeQueryAllocate(localOutArg);
		WrapperUtils.throwOnError(i);
		return ((long?)localOutArg.value).Value;
	  }
	}

}