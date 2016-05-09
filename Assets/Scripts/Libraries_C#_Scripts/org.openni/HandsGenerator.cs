namespace org.openni
{

	public class HandsGenerator : Generator
	{
	  private Observable<ActiveHandEventArgs> handCreateEvent;
	  private Observable<ActiveHandEventArgs> handUpdateEvent;
	  private Observable<InactiveHandEventArgs> handDestroyEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: HandsGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal HandsGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.handCreateEvent = new ObservableAnonymousInnerClassHelper(this);
		this.handUpdateEvent = new ObservableAnonymousInnerClassHelper2(this);
		this.handDestroyEvent = new ObservableAnonymousInnerClassHelper3(this);
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly HandsGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper(HandsGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterHandCallbacks(outerInstance.toNative(), this, "callback", null, null, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterHandCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt, Point3D paramAnonymousPoint3D, float paramAnonymousFloat)
		  {
			this.notify(new ActiveHandEventArgs(paramAnonymousInt, paramAnonymousPoint3D, paramAnonymousFloat));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper2 : Observable
	  {
		  private readonly HandsGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper2(HandsGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterHandCallbacks(outerInstance.toNative(), this, null, "callback", null, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterHandCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt, Point3D paramAnonymousPoint3D, float paramAnonymousFloat)
		  {
			this.notify(new ActiveHandEventArgs(paramAnonymousInt, paramAnonymousPoint3D, paramAnonymousFloat));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper3 : Observable
	  {
		  private readonly HandsGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper3(HandsGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterHandCallbacks(outerInstance.toNative(), this, null, null, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterHandCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt, float paramAnonymousFloat)
		  {
			this.notify(new InactiveHandEventArgs(paramAnonymousInt, paramAnonymousFloat));
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static HandsGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static HandsGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateHandsGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		HandsGenerator localHandsGenerator = (HandsGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.HANDS);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localHandsGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static HandsGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static HandsGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static HandsGenerator create(Context paramContext) throws GeneralException
	  public static HandsGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void StopTracking(int paramInt) throws StatusException
	  public virtual void StopTracking(int paramInt)
	  {
		int i = NativeMethods.xnStopTracking(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void StopTrackingAll() throws StatusException
	  public virtual void StopTrackingAll()
	  {
		int i = NativeMethods.xnStopTrackingAll(toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void StartTracking(Point3D paramPoint3D) throws StatusException
	  public virtual void StartTracking(Point3D paramPoint3D)
	  {
		int i = NativeMethods.xnStartTracking(toNative(), paramPoint3D.X, paramPoint3D.Y, paramPoint3D.Z);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void SetSmoothing(float paramFloat) throws StatusException
	  public virtual void SetSmoothing(float paramFloat)
	  {
		int i = NativeMethods.xnSetTrackingSmoothing(toNative(), paramFloat);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public HandTouchingFOVEdgeCapability getHandTouchingFOVEdgeCapability() throws StatusException
	  public virtual HandTouchingFOVEdgeCapability HandTouchingFOVEdgeCapability
	  {
		  get
		  {
			return new HandTouchingFOVEdgeCapability(this);
		  }
	  }

	  public virtual IObservable<ActiveHandEventArgs> HandCreateEvent
	  {
		  get
		  {
			return this.handCreateEvent;
		  }
	  }

	  public virtual IObservable<ActiveHandEventArgs> HandUpdateEvent
	  {
		  get
		  {
			return this.handUpdateEvent;
		  }
	  }

	  public virtual IObservable<InactiveHandEventArgs> HandDestroyEvent
	  {
		  get
		  {
			return this.handDestroyEvent;
		  }
	  }
	}

}