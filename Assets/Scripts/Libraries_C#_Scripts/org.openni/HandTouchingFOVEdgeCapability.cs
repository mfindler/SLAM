namespace org.openni
{

	public class HandTouchingFOVEdgeCapability : CapabilityBase
	{
	  private Observable<ActiveHandDirectionEventArgs> handTouchingFOVEdgeEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public HandTouchingFOVEdgeCapability(ProductionNode paramProductionNode) throws StatusException
	  public HandTouchingFOVEdgeCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.handTouchingFOVEdgeEvent = new ObservableAnonymousInnerClassHelper(this);
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly HandTouchingFOVEdgeCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper(HandTouchingFOVEdgeCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToHandTouchingFOVEdge(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromHandTouchingFOVEdge(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt1, Point3D paramAnonymousPoint3D, float paramAnonymousFloat, int paramAnonymousInt2)
		  {
			this.notify(new ActiveHandDirectionEventArgs(paramAnonymousInt1, paramAnonymousPoint3D, paramAnonymousFloat, Direction.fromNative(paramAnonymousInt2)));
		  }
	  }

	  public virtual IObservable<ActiveHandDirectionEventArgs> HandTouchingFOVEdgeEvent
	  {
		  get
		  {
			return this.handTouchingFOVEdgeEvent;
		  }
	  }
	}

}