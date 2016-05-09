namespace org.openni
{

	public class CroppingCapability : CapabilityBase
	{
	  private StateChangedObservable croppingChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public CroppingCapability(ProductionNode paramProductionNode) throws StatusException
	  public CroppingCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.croppingChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly CroppingCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(CroppingCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToCroppingChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromCroppingChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setCropping(Cropping paramCropping) throws StatusException
	  public virtual Cropping Cropping
	  {
		  set
		  {
			int i = NativeMethods.xnSetCropping(toNative(), value.XOffset, value.YOffset, value.XSize, value.YSize, value.Enabled);
			WrapperUtils.throwOnError(i);
		  }
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			OutArg localOutArg3 = new OutArg();
			OutArg localOutArg4 = new OutArg();
			OutArg localOutArg5 = new OutArg();
			int i = NativeMethods.xnGetCropping(toNative(), localOutArg1, localOutArg2, localOutArg3, localOutArg4, localOutArg5);
			WrapperUtils.throwOnError(i);
			return new Cropping(((int?)localOutArg1.value).Value, ((int?)localOutArg2.value).Value, ((int?)localOutArg3.value).Value, ((int?)localOutArg4.value).Value, ((bool?)localOutArg5.value).Value);
		  }
	  }


	  public virtual IStateChangedObservable CroppingChangedEvent
	  {
		  get
		  {
			return this.croppingChanged;
		  }
	  }
	}

}