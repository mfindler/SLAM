namespace org.openni
{

	public class GeneralIntCapability : CapabilityBase
	{
	  private StateChangedObservable valueChanged;
	  private readonly string capName;
	  private int min;
	  private int max;
	  private int step;
	  private int defaultVal;
	  private bool autoSupported;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public GeneralIntCapability(ProductionNode paramProductionNode, Capability paramCapability) throws StatusException
	  public GeneralIntCapability(ProductionNode paramProductionNode, Capability paramCapability) : base(paramProductionNode)
	  {
		this.capName = paramCapability.Name;

		OutArg localOutArg1 = new OutArg();
		OutArg localOutArg2 = new OutArg();
		OutArg localOutArg3 = new OutArg();
		OutArg localOutArg4 = new OutArg();
		OutArg localOutArg5 = new OutArg();

		int i = NativeMethods.xnGetGeneralIntRange(toNative(), CapName, localOutArg1, localOutArg2, localOutArg3, localOutArg4, localOutArg5);
		WrapperUtils.throwOnError(i);

		this.min = ((int?)localOutArg1.value).Value;
		this.max = ((int?)localOutArg2.value).Value;
		this.step = ((int?)localOutArg3.value).Value;
		this.defaultVal = ((int?)localOutArg4.value).Value;
		this.autoSupported = ((bool?)localOutArg5.value).Value;

		this.valueChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly GeneralIntCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(GeneralIntCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToGeneralIntValueChange(outerInstance.toNative(), outerInstance.CapName, this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromNodeErrorStateChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual int Min
	  {
		  get
		  {
			return this.min;
		  }
	  }

	  public virtual int Max
	  {
		  get
		  {
			return this.max;
		  }
	  }

	  public virtual int Step
	  {
		  get
		  {
			return this.step;
		  }
	  }

	  public virtual int Default
	  {
		  get
		  {
			return this.defaultVal;
		  }
	  }

	  public virtual bool AutoSupported
	  {
		  get
		  {
			return this.autoSupported;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int getValue() throws StatusException
	  public virtual int Value
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetGeneralIntValue(toNative(), this.capName, localOutArg);
			WrapperUtils.throwOnError(i);
			return ((int?)localOutArg.value).Value;
		  }
		  set
		  {
			int i = NativeMethods.xnSetGeneralIntValue(toNative(), this.capName, value);
			WrapperUtils.throwOnError(i);
		  }
	  }


	  public virtual IStateChangedObservable ValueChangedEvent
	  {
		  get
		  {
			return this.valueChanged;
		  }
	  }

	  internal virtual string CapName
	  {
		  get
		  {
			return this.capName;
		  }
	  }
	}

}