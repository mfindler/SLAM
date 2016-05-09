namespace org.openni
{

	public class AlternativeViewpointCapability : CapabilityBase
	{
	  private StateChangedObservable viewPointChanged;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public AlternativeViewpointCapability(ProductionNode paramProductionNode) throws StatusException
	  public AlternativeViewpointCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.viewPointChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly AlternativeViewpointCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(AlternativeViewpointCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToViewPointChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromViewPointChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  public virtual bool isViewpointSupported(ProductionNode paramProductionNode)
	  {
		return NativeMethods.xnIsViewPointSupported(toNative(), paramProductionNode.toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setViewpoint(ProductionNode paramProductionNode) throws StatusException
	  public virtual ProductionNode Viewpoint
	  {
		  set
		  {
			int i = NativeMethods.xnSetViewPoint(toNative(), value.toNative());
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void resetViewpoint() throws StatusException
	  public virtual void resetViewpoint()
	  {
		int i = NativeMethods.xnResetViewPoint(toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool isViewpointAs(ProductionNode paramProductionNode)
	  {
		return NativeMethods.xnIsViewPointAs(toNative(), paramProductionNode.toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public XYCoordinates getPixelCoordinatesInViewpoint(ProductionNode paramProductionNode, int paramInt1, int paramInt2) throws StatusException
	  public virtual XYCoordinates getPixelCoordinatesInViewpoint(ProductionNode paramProductionNode, int paramInt1, int paramInt2)
	  {
		OutArg localOutArg1 = new OutArg();
		OutArg localOutArg2 = new OutArg();
		int i = NativeMethods.xnGetPixelCoordinatesInViewPoint(toNative(), paramProductionNode.toNative(), paramInt1, paramInt2, localOutArg1, localOutArg2);
		WrapperUtils.throwOnError(i);
		return new XYCoordinates(((int?)localOutArg1.value).Value, ((int?)localOutArg2.value).Value);
	  }

	  public virtual IStateChangedObservable ViewPointChangedEvent
	  {
		  get
		  {
			return this.viewPointChanged;
		  }
	  }
	}

}