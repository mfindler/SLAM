namespace org.openni
{

	public class AntiFlickerCapability : CapabilityBase
	{
	  private StateChangedObservable powerLineFrequencyChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public AntiFlickerCapability(ProductionNode paramProductionNode) throws StatusException
	  public AntiFlickerCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.powerLineFrequencyChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly AntiFlickerCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(AntiFlickerCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToPowerLineFrequencyChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromPowerLineFrequencyChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual PowerLineFrequency PowerLineFrequency
	  {
		  get
		  {
			return PowerLineFrequency.fromNative(NativeMethods.xnGetPowerLineFrequency(toNative()));
		  }
		  set
		  {
			int i = NativeMethods.xnSetPowerLineFrequency(toNative(), value.toNative());
			WrapperUtils.throwOnError(i);
		  }
	  }


	  public virtual IStateChangedObservable PowerLineFrequencyChangedEvent
	  {
		  get
		  {
			return this.powerLineFrequencyChanged;
		  }
	  }
	}

}