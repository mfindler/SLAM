namespace org.openni
{

	public class FrameSyncCapability : CapabilityBase
	{
	  private StateChangedObservable frameSyncChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public FrameSyncCapability(ProductionNode paramProductionNode) throws StatusException
	  public FrameSyncCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.frameSyncChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly FrameSyncCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(FrameSyncCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToFrameSyncChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromFrameSyncChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual bool canFrameSyncWith(Generator paramGenerator)
	  {
		return NativeMethods.xnCanFrameSyncWith(toNative(), paramGenerator.toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void frameSyncWith(Generator paramGenerator) throws StatusException
	  public virtual void frameSyncWith(Generator paramGenerator)
	  {
		int i = NativeMethods.xnFrameSyncWith(toNative(), paramGenerator.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void stopFrameSyncWith(Generator paramGenerator) throws StatusException
	  public virtual void stopFrameSyncWith(Generator paramGenerator)
	  {
		int i = NativeMethods.xnStopFrameSyncWith(toNative(), paramGenerator.toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool isFrameSyncedWith(Generator paramGenerator)
	  {
		return NativeMethods.xnIsFrameSyncedWith(toNative(), paramGenerator.toNative());
	  }

	  public virtual IStateChangedObservable FrameSyncChangedEvent
	  {
		  get
		  {
			return this.frameSyncChanged;
		  }
	  }
	}

}