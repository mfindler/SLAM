using System;

namespace org.openni
{

	public class PoseDetectionCapability : CapabilityBase
	{
	  private Observable<PoseDetectionEventArgs> poseDetectedEvent;
	  private Observable<PoseDetectionEventArgs> outOfPoseEvent;
	  private Observable<PoseDetectionInProgressEventArgs> poseDetectionInProgressEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public PoseDetectionCapability(ProductionNode paramProductionNode) throws StatusException
	  public PoseDetectionCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.poseDetectedEvent = new ObservableAnonymousInnerClassHelper(this);
		this.outOfPoseEvent = new ObservableAnonymousInnerClassHelper2(this);
		this.poseDetectionInProgressEvent = new ObservableAnonymousInnerClassHelper3(this);
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly PoseDetectionCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper(PoseDetectionCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToPoseDetected(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromPoseDetected(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, int paramAnonymousInt)
		  {
			this.notify(new PoseDetectionEventArgs(paramAnonymousString, paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper2 : Observable
	  {
		  private readonly PoseDetectionCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper2(PoseDetectionCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToOutOfPose(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromOutOfPose(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, int paramAnonymousInt)
		  {
			this.notify(new PoseDetectionEventArgs(paramAnonymousString, paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper3 : Observable
	  {
		  private readonly PoseDetectionCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper3(PoseDetectionCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToPoseDetectionInProgress(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromPoseDetectionInProgress(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(string paramAnonymousString, int paramAnonymousInt1, int paramAnonymousInt2)
		  {
			this.notify(new PoseDetectionInProgressEventArgs(paramAnonymousString, paramAnonymousInt1, PoseDetectionStatus.fromNative(paramAnonymousInt2)));
		  }
	  }

	  public virtual int NumberOfPoses
	  {
		  get
		  {
			return NativeMethods.xnGetNumberOfPoses(toNative());
		  }
	  }

	  public virtual bool isPoseSupported(string paramString)
	  {
		return NativeMethods.xnIsPoseSupported(toNative(), paramString);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void getPoseStatus(int paramInt, String paramString, OutArg<Nullable<long>> paramOutArg, OutArg<PoseDetectionStatus> paramOutArg1, OutArg<PoseDetectionState> paramOutArg2) throws StatusException
	  public virtual void getPoseStatus(int paramInt, string paramString, OutArg<long?> paramOutArg, OutArg<PoseDetectionStatus> paramOutArg1, OutArg<PoseDetectionState> paramOutArg2)
	  {
		OutArg localOutArg1 = new OutArg();
		OutArg localOutArg2 = new OutArg();
		int i = NativeMethods.xnGetPoseStatus(toNative(), paramInt, paramString, paramOutArg, localOutArg1, localOutArg2);
		paramOutArg1.value = PoseDetectionStatus.fromNative(((int?)localOutArg1.value).Value);
		paramOutArg2.value = PoseDetectionState.fromNative(((int?)localOutArg2.value).Value);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String[] getAllAvailablePoses() throws StatusException
	  public virtual string[] AllAvailablePoses
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetAllAvailablePoses(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
			return (string[])localOutArg.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: @Deprecated public void StartPoseDetection(String paramString, int paramInt) throws StatusException
	  [Obsolete]
	  public virtual void StartPoseDetection(string paramString, int paramInt)
	  {
		int i = NativeMethods.xnStartPoseDetection(toNative(), paramString, paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: @Deprecated public void StopPoseDetection(int paramInt) throws StatusException
	  [Obsolete]
	  public virtual void StopPoseDetection(int paramInt)
	  {
		int i = NativeMethods.xnStopPoseDetection(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void startPoseDetection(String paramString, int paramInt) throws StatusException
	  public virtual void startPoseDetection(string paramString, int paramInt)
	  {
		int i = NativeMethods.xnStartPoseDetection(toNative(), paramString, paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void stopPoseDetection(int paramInt) throws StatusException
	  public virtual void stopPoseDetection(int paramInt)
	  {
		int i = NativeMethods.xnStopPoseDetection(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void stopSinglePoseDetection(int paramInt, String paramString) throws StatusException
	  public virtual void stopSinglePoseDetection(int paramInt, string paramString)
	  {
		int i = NativeMethods.xnStopSinglePoseDetection(toNative(), paramInt, paramString);
		WrapperUtils.throwOnError(i);
	  }

	  public virtual IObservable<PoseDetectionEventArgs> PoseDetectedEvent
	  {
		  get
		  {
			return this.poseDetectedEvent;
		  }
	  }

	  public virtual IObservable<PoseDetectionEventArgs> OutOfPoseEvent
	  {
		  get
		  {
			return this.outOfPoseEvent;
		  }
	  }

	  public virtual IObservable<PoseDetectionInProgressEventArgs> PoseDetectionInProgressEvent
	  {
		  get
		  {
			return this.poseDetectionInProgressEvent;
		  }
	  }
	}

}