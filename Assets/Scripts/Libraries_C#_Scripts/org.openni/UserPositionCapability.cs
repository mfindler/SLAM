namespace org.openni
{

	public class UserPositionCapability : CapabilityBase
	{
	  private StateChangedObservable userPositionChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public UserPositionCapability(ProductionNode paramProductionNode) throws StatusException
	  public UserPositionCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.userPositionChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly UserPositionCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(UserPositionCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToUserPositionChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromUserPositionChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual int SupportedCount
	  {
		  get
		  {
			return NativeMethods.xnGetSupportedUserPositionsCount(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setUserPosition(int paramInt, BoundingBox3D paramBoundingBox3D) throws StatusException
	  public virtual void setUserPosition(int paramInt, BoundingBox3D paramBoundingBox3D)
	  {
		Point3D localPoint3D1 = paramBoundingBox3D.LeftBottomNear;
		Point3D localPoint3D2 = paramBoundingBox3D.RightTopFar;
		int i = NativeMethods.xnSetUserPosition(toNative(), paramInt, localPoint3D1.X, localPoint3D1.Y, localPoint3D1.Z, localPoint3D2.X, localPoint3D2.Y, localPoint3D2.Z);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public BoundingBox3D getUserPosition(int paramInt) throws StatusException
	  public virtual BoundingBox3D getUserPosition(int paramInt)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetUserPosition(toNative(), paramInt, localOutArg);
		WrapperUtils.throwOnError(i);
		return (BoundingBox3D)localOutArg.value;
	  }

	  public virtual IStateChangedObservable UserPositionChangedEvent
	  {
		  get
		  {
			return this.userPositionChanged;
		  }
	  }
	}

}