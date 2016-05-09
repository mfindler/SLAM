namespace org.openni
{

	public class SkeletonCapability : CapabilityBase
	{
	  private StateChangedObservable jointConfigurationChangeEvent;
	  private Observable<CalibrationStartEventArgs> calibrationStartEvent;
	  private Observable<CalibrationProgressEventArgs> calibrationInProgressEvent;
	  private Observable<CalibrationProgressEventArgs> calibrationCompleteEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SkeletonCapability(ProductionNode paramProductionNode) throws StatusException
	  public SkeletonCapability(ProductionNode paramProductionNode) : base(paramProductionNode)
	  {

		this.jointConfigurationChangeEvent = new StateChangedObservableAnonymousInnerClassHelper(this);
		this.calibrationStartEvent = new ObservableAnonymousInnerClassHelper(this);
		this.calibrationInProgressEvent = new ObservableAnonymousInnerClassHelper2(this);
		this.calibrationCompleteEvent = new ObservableAnonymousInnerClassHelper3(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly SkeletonCapability outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(SkeletonCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal override int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToJointConfigurationChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromJointConfigurationChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly SkeletonCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper(SkeletonCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToCalibrationStart(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromCalibrationStart(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt)
		  {
			this.notify(new CalibrationStartEventArgs(paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper2 : Observable
	  {
		  private readonly SkeletonCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper2(SkeletonCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToCalibrationInProgress(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromCalibrationInProgress(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt1, int paramAnonymousInt2)
		  {
			this.notify(new CalibrationProgressEventArgs(paramAnonymousInt1, CalibrationProgressStatus.fromNative(paramAnonymousInt2)));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper3 : Observable
	  {
		  private readonly SkeletonCapability outerInstance;

		  public ObservableAnonymousInnerClassHelper3(SkeletonCapability outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToCalibrationComplete(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromCalibrationComplete(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt1, int paramAnonymousInt2)
		  {
			this.notify(new CalibrationProgressEventArgs(paramAnonymousInt1, CalibrationProgressStatus.fromNative(paramAnonymousInt2)));
		  }
	  }

	  public virtual bool isJointAvailable(SkeletonJoint paramSkeletonJoint)
	  {
		return NativeMethods.xnIsJointAvailable(toNative(), paramSkeletonJoint.toNative());
	  }

	  public virtual bool isProfileAvailable(SkeletonProfile paramSkeletonProfile)
	  {
		return NativeMethods.xnIsProfileAvailable(toNative(), paramSkeletonProfile.toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setSkeletonProfile(SkeletonProfile paramSkeletonProfile) throws StatusException
	  public virtual SkeletonProfile SkeletonProfile
	  {
		  set
		  {
			int i = NativeMethods.xnSetSkeletonProfile(toNative(), value.toNative());
			WrapperUtils.throwOnError(i);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setJointActive(SkeletonJoint paramSkeletonJoint, boolean paramBoolean) throws StatusException
	  public virtual void setJointActive(SkeletonJoint paramSkeletonJoint, bool paramBoolean)
	  {
		int i = NativeMethods.xnSetJointActive(toNative(), paramSkeletonJoint.toNative(), paramBoolean);
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool isJointActive(SkeletonJoint paramSkeletonJoint)
	  {
		return NativeMethods.xnIsJointActive(toNative(), paramSkeletonJoint.toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SkeletonJoint[] enumerateActiveJoints() throws StatusException
	  public virtual SkeletonJoint[] enumerateActiveJoints()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerateActiveJoints(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		SkeletonJoint[] arrayOfSkeletonJoint = new SkeletonJoint[((int?[])localOutArg.value).Length];
		for (int j = 0; j < ((int?[])localOutArg.value).Length; j++)
		{
		  arrayOfSkeletonJoint[j] = SkeletonJoint.fromNative(((int?[])localOutArg.value)[j].intValue());
		}
		return arrayOfSkeletonJoint;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SkeletonJointTransformation getSkeletonJoint(int paramInt, SkeletonJoint paramSkeletonJoint) throws StatusException
	  public virtual SkeletonJointTransformation getSkeletonJoint(int paramInt, SkeletonJoint paramSkeletonJoint)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetSkeletonJoint(toNative(), paramInt, paramSkeletonJoint.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return (SkeletonJointTransformation)localOutArg.value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SkeletonJointPosition getSkeletonJointPosition(int paramInt, SkeletonJoint paramSkeletonJoint) throws StatusException
	  public virtual SkeletonJointPosition getSkeletonJointPosition(int paramInt, SkeletonJoint paramSkeletonJoint)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetSkeletonJointPosition(toNative(), paramInt, paramSkeletonJoint.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return (SkeletonJointPosition)localOutArg.value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SkeletonJointOrientation getSkeletonJointOrientation(int paramInt, SkeletonJoint paramSkeletonJoint) throws StatusException
	  public virtual SkeletonJointOrientation getSkeletonJointOrientation(int paramInt, SkeletonJoint paramSkeletonJoint)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetSkeletonJointOrientation(toNative(), paramInt, paramSkeletonJoint.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return (SkeletonJointOrientation)localOutArg.value;
	  }

	  public virtual bool isSkeletonTracking(int paramInt)
	  {
		return NativeMethods.xnIsSkeletonTracking(toNative(), paramInt);
	  }

	  public virtual bool isSkeletonCalibrated(int paramInt)
	  {
		return NativeMethods.xnIsSkeletonCalibrated(toNative(), paramInt);
	  }

	  public virtual bool isSkeletonCalibrating(int paramInt)
	  {
		return NativeMethods.xnIsSkeletonCalibrating(toNative(), paramInt);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void requestSkeletonCalibration(int paramInt, boolean paramBoolean) throws StatusException
	  public virtual void requestSkeletonCalibration(int paramInt, bool paramBoolean)
	  {
		int i = NativeMethods.xnRequestSkeletonCalibration(toNative(), paramInt, paramBoolean);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void requestSkeletonCalibration(int paramInt) throws StatusException
	  public virtual void requestSkeletonCalibration(int paramInt)
	  {
		requestSkeletonCalibration(paramInt, false);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void abortSkeletonCalibration(int paramInt) throws StatusException
	  public virtual void abortSkeletonCalibration(int paramInt)
	  {
		int i = NativeMethods.xnAbortSkeletonCalibration(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void saveSkeletonCalibrationDataToFile(int paramInt, String paramString) throws StatusException
	  public virtual void saveSkeletonCalibrationDataToFile(int paramInt, string paramString)
	  {
		int i = NativeMethods.xnSaveSkeletonCalibrationDataToFile(toNative(), paramInt, paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void loadSkeletonCalibrationDatadFromFile(int paramInt, String paramString) throws StatusException
	  public virtual void loadSkeletonCalibrationDatadFromFile(int paramInt, string paramString)
	  {
		int i = NativeMethods.xnLoadSkeletonCalibrationDataFromFile(toNative(), paramInt, paramString);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void saveSkeletonCalibrationData(int paramInt1, int paramInt2) throws StatusException
	  public virtual void saveSkeletonCalibrationData(int paramInt1, int paramInt2)
	  {
		int i = NativeMethods.xnSaveSkeletonCalibrationData(toNative(), paramInt1, paramInt2);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void loadSkeletonCalibrationData(int paramInt1, int paramInt2) throws StatusException
	  public virtual void loadSkeletonCalibrationData(int paramInt1, int paramInt2)
	  {
		int i = NativeMethods.xnLoadSkeletonCalibrationData(toNative(), paramInt1, paramInt2);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void clearSkeletonCalibrationData(int paramInt) throws StatusException
	  public virtual void clearSkeletonCalibrationData(int paramInt)
	  {
		int i = NativeMethods.xnClearSkeletonCalibrationData(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool isSkeletonCalibrationData(int paramInt)
	  {
		return NativeMethods.xnIsSkeletonCalibrationData(toNative(), paramInt);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void startTracking(int paramInt) throws StatusException
	  public virtual void startTracking(int paramInt)
	  {
		int i = NativeMethods.xnStartSkeletonTracking(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void stopTracking(int paramInt) throws StatusException
	  public virtual void stopTracking(int paramInt)
	  {
		int i = NativeMethods.xnStopSkeletonTracking(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void reset(int paramInt) throws StatusException
	  public virtual void reset(int paramInt)
	  {
		int i = NativeMethods.xnResetSkeleton(toNative(), paramInt);
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool needPoseForCalibration()
	  {
		return NativeMethods.xnNeedPoseForSkeletonCalibration(toNative());
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public String getSkeletonCalibrationPose() throws StatusException
	  public virtual string SkeletonCalibrationPose
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetSkeletonCalibrationPose(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
			return (string)localOutArg.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void setSmoothing(float paramFloat) throws StatusException
	  public virtual float Smoothing
	  {
		  set
		  {
			int i = NativeMethods.xnSetSkeletonSmoothing(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }

	  public virtual IStateChangedObservable JointConfigurationChangeEvent
	  {
		  get
		  {
			return this.jointConfigurationChangeEvent;
		  }
	  }

	  public virtual IObservable<CalibrationStartEventArgs> CalibrationStartEvent
	  {
		  get
		  {
			return this.calibrationStartEvent;
		  }
	  }

	  public virtual IObservable<CalibrationProgressEventArgs> CalibrationInProgressEvent
	  {
		  get
		  {
			return this.calibrationInProgressEvent;
		  }
	  }

	  public virtual IObservable<CalibrationProgressEventArgs> CalibrationCompleteEvent
	  {
		  get
		  {
			return this.calibrationCompleteEvent;
		  }
	  }
	}

}