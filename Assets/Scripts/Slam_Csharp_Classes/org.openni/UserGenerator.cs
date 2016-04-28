namespace org.openni
{

	public class UserGenerator : Generator
	{
	  private Observable<UserEventArgs> newUserEvent;
	  private Observable<UserEventArgs> lostUserEvent;
	  private Observable<UserEventArgs> userExitEvent;
	  private Observable<UserEventArgs> userReenterEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: UserGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal UserGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.newUserEvent = new ObservableAnonymousInnerClassHelper(this);
		this.lostUserEvent = new ObservableAnonymousInnerClassHelper2(this);
		this.userExitEvent = new ObservableAnonymousInnerClassHelper3(this);
		this.userReenterEvent = new ObservableAnonymousInnerClassHelper4(this);
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly UserGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper(UserGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterUserCallbacks(outerInstance.toNative(), this, "callback", null, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterUserCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt)
		  {
			this.notify(new UserEventArgs(paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper2 : Observable
	  {
		  private readonly UserGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper2(UserGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterUserCallbacks(outerInstance.toNative(), this, null, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterUserCallbacks(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt)
		  {
			this.notify(new UserEventArgs(paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper3 : Observable
	  {
		  private readonly UserGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper3(UserGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToUserExit(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromUserExit(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt)
		  {
			this.notify(new UserEventArgs(paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper4 : Observable
	  {
		  private readonly UserGenerator outerInstance;

		  public ObservableAnonymousInnerClassHelper4(UserGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToUserReEnter(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromUserExit(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt)
		  {
			this.notify(new UserEventArgs(paramAnonymousInt));
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static UserGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static UserGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateUserGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		UserGenerator localUserGenerator = (UserGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.USER);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localUserGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static UserGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static UserGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static UserGenerator create(Context paramContext) throws GeneralException
	  public static UserGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

	  public virtual int NumberOfUsers
	  {
		  get
		  {
			return NativeMethods.xnGetNumberOfUsers(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public int[] getUsers() throws StatusException
	  public virtual int[] Users
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetUsers(toNative(), localOutArg);
			WrapperUtils.throwOnError(i);
    
			int[] arrayOfInt = new int[((int?[])localOutArg.value).Length];
			for (int j = 0; j < ((int?[])localOutArg.value).Length; j++)
			{
			  arrayOfInt[j] = ((int?[])localOutArg.value)[j].intValue();
			}
			return arrayOfInt;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Point3D getUserCoM(int paramInt) throws StatusException
	  public virtual Point3D getUserCoM(int paramInt)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetUserCoM(toNative(), paramInt, localOutArg);
		WrapperUtils.throwOnError(i);
		return (Point3D)localOutArg.value;
	  }

	  public virtual void getUserPixels(int paramInt, SceneMetaData paramSceneMetaData)
	  {
		NativeMethods.xnGetUserPixels(toNative(), paramInt, paramSceneMetaData);
	  }

	  public virtual SceneMetaData getUserPixels(int paramInt)
	  {
		SceneMetaData localSceneMetaData = new SceneMetaData();
		getUserPixels(paramInt, localSceneMetaData);
		return localSceneMetaData;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public PoseDetectionCapability getPoseDetectionCapability() throws StatusException
	  public virtual PoseDetectionCapability PoseDetectionCapability
	  {
		  get
		  {
			return new PoseDetectionCapability(this);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SkeletonCapability getSkeletonCapability() throws StatusException
	  public virtual SkeletonCapability SkeletonCapability
	  {
		  get
		  {
			return new SkeletonCapability(this);
		  }
	  }

	  public virtual IObservable<UserEventArgs> NewUserEvent
	  {
		  get
		  {
			return this.newUserEvent;
		  }
	  }

	  public virtual IObservable<UserEventArgs> LostUserEvent
	  {
		  get
		  {
			return this.lostUserEvent;
		  }
	  }

	  public virtual IObservable<UserEventArgs> UserExitEvent
	  {
		  get
		  {
			return this.userExitEvent;
		  }
	  }

	  public virtual IObservable<UserEventArgs> UserReenterEvent
	  {
		  get
		  {
			return this.userReenterEvent;
		  }
	  }
	}

}