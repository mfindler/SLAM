namespace org.openni
{

	public class GestureGenerator : Generator
	{
	  private Observable<GestureRecognizedEventArgs> gestureRecognizedEvent;
	  private Observable<GestureProgressEventArgs> gestureProgressEvent;
	  private Observable<GesturePositionEventArgs> gestureIntermediateStageCompletedEvent;
	  private Observable<GesturePositionEventArgs> gestureReadyForNextIntermediateStageEvent;
	  private StateChangedObservable gestureChangedEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: GestureGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal GestureGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.gestureRecognizedEvent = new ObservableAnonymousInnerClassHelper(this);
		this.gestureProgressEvent = new ObservableAnonymousInnerClassHelper2(this);
		this.gestureIntermediateStageCompletedEvent = new ObservableAnonymousInnerClassHelper3(this);
		this.gestureReadyForNextIntermediateStageEvent = new ObservableAnonymousInnerClassHelper4(this);
		this.gestureChangedEvent = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly GestureGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper(GestureGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterGestureCallbacks(outerInstance.toNative(), this, "callback", null, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterHandCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, Point3D paramAnonymousPoint3D1, Point3D paramAnonymousPoint3D2)
		  {
			this.notify(new GestureRecognizedEventArgs(paramAnonymousString, paramAnonymousPoint3D1, paramAnonymousPoint3D2));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper2 : Observable
	  {
		  private readonly GestureGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper2(GestureGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterGestureCallbacks(outerInstance.toNative(), this, null, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterHandCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, Point3D paramAnonymousPoint3D, float paramAnonymousFloat)
		  {
			this.notify(new GestureProgressEventArgs(paramAnonymousString, paramAnonymousPoint3D, paramAnonymousFloat));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper3 : Observable
	  {
		  private readonly GestureGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper3(GestureGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToGestureIntermediateStageCompleted(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromGestureIntermediateStageCompleted(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, Point3D paramAnonymousPoint3D)
		  {
			this.notify(new GesturePositionEventArgs(paramAnonymousString, paramAnonymousPoint3D));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper4 : Observable
	  {
		  private readonly GestureGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper4(GestureGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToGestureReadyForNextIntermediateStage(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromGestureReadyForNextIntermediateStage(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, Point3D paramAnonymousPoint3D)
		  {
			this.notify(new GesturePositionEventArgs(paramAnonymousString, paramAnonymousPoint3D));
		  }
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly GestureGenerator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(GestureGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToGestureChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromGestureChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static GestureGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static GestureGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateGestureGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		GestureGenerator localGestureGenerator = (GestureGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.GESTURE);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localGestureGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static GestureGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static GestureGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static GestureGenerator create(Context paramContext) throws GeneralException
	  public static GestureGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addGesture(String paramString) throws StatusException
	  public virtual void addGesture(string paramString)
	  {
		int i = NativeMethods.xnAddGesture(toNative(), paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addGesture(String paramString, BoundingBox3D paramBoundingBox3D) throws StatusException
	  public virtual void addGesture(string paramString, BoundingBox3D paramBoundingBox3D)
	  {
		if (paramBoundingBox3D == null)
		{
		  addGesture(paramString);
		  return;
		}
		int i = NativeMethods.xnAddGesture(toNative(), paramString, paramBoundingBox3D.Mins.X, paramBoundingBox3D.Mins.Y, paramBoundingBox3D.Mins.Z, paramBoundingBox3D.Maxs.X, paramBoundingBox3D.Maxs.Y, paramBoundingBox3D.Maxs.Z);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void removeGesture(String paramString) throws StatusException
	  public virtual void removeGesture(string paramString)
	  {
		int i = NativeMethods.xnRemoveGesture(toNative(), paramString);
		WrapperUtils.throwOnError(i);
	  }

	  public virtual int NumberOfAvailableGestures
	  {
		  get
		  {
			return NativeMethods.xnGetNumberOfAvailableGestures(toNative());
		  }
	  }

	  public virtual bool isGestureAvailable(string paramString)
	  {
		return NativeMethods.xnIsGestureAvailable(toNative(), paramString);
	  }

	  public virtual bool isGestureProgressSupported(string paramString)
	  {
		return NativeMethods.xnIsGestureProgressSupported(toNative(), paramString);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String[] enumerateAllGestures() throws StatusException
	  public virtual string[] enumerateAllGestures()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerateAllGestures(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return (string[])localOutArg.value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String[] getAllActiveGestures() throws StatusException
	  public virtual string[] AllActiveGestures
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetAllActiveGestures(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
			return (string[])localOutArg.value;
		  }
	  }

	  public virtual IObservable<GestureRecognizedEventArgs> GestureRecognizedEvent
	  {
		  get
		  {
			return this.gestureRecognizedEvent;
		  }
	  }

	  public virtual IObservable<GestureProgressEventArgs> GestureProgressEvent
	  {
		  get
		  {
			return this.gestureProgressEvent;
		  }
	  }

	  public virtual IObservable<GesturePositionEventArgs> GestureIntermediateStageCompletedEvent
	  {
		  get
		  {
			return this.gestureIntermediateStageCompletedEvent;
		  }
	  }

	  public virtual IObservable<GesturePositionEventArgs> GestureReadyForNextIntermediateStageEvent
	  {
		  get
		  {
			return this.gestureReadyForNextIntermediateStageEvent;
		  }
	  }

	  public virtual IStateChangedObservable GestureChangedEvent
	  {
		  get
		  {
			return this.gestureChangedEvent;
		  }
	  }
	}

}