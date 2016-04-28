namespace org.openni
{

	public class ErrorStateCapability : CapabilityBase
	{
	  private StateChangedObservable errorStateChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ErrorStateCapability(ProductionNode paramProductionNode) throws StatusException
	  public ErrorStateCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.errorStateChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly ErrorStateCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(ErrorStateCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToNodeErrorStateChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromNodeErrorStateChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual string ErrorState
	  {
		  get
		  {
			int i = NativeMethods.xnGetNodeErrorState(toNative());
			if (i == 0)
			{
			  return null;
			}
			return NativeMethods.xnGetStatusString(i);
		  }
	  }

	  public virtual IStateChangedObservable ErrorStateChangedEvent
	  {
		  get
		  {
			return this.errorStateChanged;
		  }
	  }
	}

}