namespace org.openni
{

	public class MirrorCapability : CapabilityBase
	{
	  private StateChangedObservable mirrorChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public MirrorCapability(ProductionNode paramProductionNode) throws StatusException
	  public MirrorCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.mirrorChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly MirrorCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(MirrorCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToMirrorChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromMirrorChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual bool Mirrored
	  {
		  get
		  {
			return NativeMethods.xnIsMirrored(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setMirror(boolean paramBoolean) throws StatusException
	  public virtual bool Mirror
	  {
		  set
		  {
			int i = NativeMethods.xnSetMirror(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

	  public virtual IStateChangedObservable MirrorChangedEvent
	  {
		  get
		  {
			return this.mirrorChanged;
		  }
	  }
	}

}