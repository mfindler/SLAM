namespace org.openni
{

	public class DepthGenerator : MapGenerator
	{
	  private StateChangedObservable fovChanged;
	  private DepthMap currDepthMap;
	  private int currDepthMapFrameID;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: DepthGenerator(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal DepthGenerator(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {

		this.fovChanged = new StateChangedObservableAnonymousInnerClassHelper(this);
	  }

	  private class StateChangedObservableAnonymousInnerClassHelper : StateChangedObservable
	  {
		  private readonly DepthGenerator outerInstance;

		  public StateChangedObservableAnonymousInnerClassHelper(DepthGenerator outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

		  protected internal virtual int registerNative(string paramAnonymousString, OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToDepthFieldOfViewChange(outerInstance.toNative(), this, paramAnonymousString, paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromDepthFieldOfViewChange(outerInstance.toNative(), paramAnonymousLong);
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static DepthGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static DepthGenerator create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateDepthGenerator(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		DepthGenerator localDepthGenerator = (DepthGenerator)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.DEPTH);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localDepthGenerator;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static DepthGenerator create(Context paramContext, Query paramQuery) throws GeneralException
	  public static DepthGenerator create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static DepthGenerator create(Context paramContext) throws GeneralException
	  public static DepthGenerator create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public DepthMap getDepthMap() throws GeneralException
	  public virtual DepthMap DepthMap
	  {
		  get
		  {
			int i = FrameID;
			if ((this.currDepthMap == null) || (this.currDepthMapFrameID != i))
			{
			  long l = NativeMethods.xnGetDepthMap(toNative());
			  MapOutputMode localMapOutputMode = MapOutputMode;
			  this.currDepthMap = new DepthMap(l, localMapOutputMode.XRes, localMapOutputMode.YRes);
			  this.currDepthMapFrameID = i;
			}
			return this.currDepthMap;
		  }
	  }

	  public virtual int DeviceMaxDepth
	  {
		  get
		  {
			return NativeMethods.xnGetDeviceMaxDepth(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public FieldOfView getFieldOfView() throws StatusException
	  public virtual FieldOfView FieldOfView
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
			int i = NativeMethods.xnGetDepthFieldOfView(toNative(), localOutArg1, localOutArg2);
			WrapperUtils.throwOnError(i);
			return new FieldOfView(((double?)localOutArg1.value).Value, ((double?)localOutArg2.value).Value);
		  }
	  }

	  public virtual IStateChangedObservable FieldOfViewChangedEvent
	  {
		  get
		  {
			return this.fovChanged;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Point3D[] convertProjectiveToRealWorld(Point3D[] paramArrayOfPoint3D) throws StatusException
	  public virtual Point3D[] convertProjectiveToRealWorld(Point3D[] paramArrayOfPoint3D)
	  {
		Point3D[] arrayOfPoint3D = new Point3D[paramArrayOfPoint3D.Length];
		int i = NativeMethods.xnConvertProjectiveToRealWorld(toNative(), paramArrayOfPoint3D, arrayOfPoint3D);
		WrapperUtils.throwOnError(i);
		return arrayOfPoint3D;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Point3D convertProjectiveToRealWorld(Point3D paramPoint3D) throws StatusException
	  public virtual Point3D convertProjectiveToRealWorld(Point3D paramPoint3D)
	  {
		Point3D[] arrayOfPoint3D = new Point3D[1];
		arrayOfPoint3D[0] = paramPoint3D;

		return convertProjectiveToRealWorld(arrayOfPoint3D)[0];
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Point3D[] convertRealWorldToProjective(Point3D[] paramArrayOfPoint3D) throws StatusException
	  public virtual Point3D[] convertRealWorldToProjective(Point3D[] paramArrayOfPoint3D)
	  {
		Point3D[] arrayOfPoint3D = new Point3D[paramArrayOfPoint3D.Length];
		int i = NativeMethods.xnConvertRealWorldToProjective(toNative(), paramArrayOfPoint3D, arrayOfPoint3D);
		WrapperUtils.throwOnError(i);
		return arrayOfPoint3D;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Point3D convertRealWorldToProjective(Point3D paramPoint3D) throws StatusException
	  public virtual Point3D convertRealWorldToProjective(Point3D paramPoint3D)
	  {
		Point3D[] arrayOfPoint3D = new Point3D[1];
		arrayOfPoint3D[0] = paramPoint3D;

		return convertRealWorldToProjective(arrayOfPoint3D)[0];
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public UserPositionCapability getUserPositionCapability() throws StatusException
	  public virtual UserPositionCapability UserPositionCapability
	  {
		  get
		  {
			return new UserPositionCapability(this);
		  }
	  }

	  public virtual void getMetaData(DepthMetaData paramDepthMetaData)
	  {
		NativeMethods.xnGetDepthMetaData(toNative(), paramDepthMetaData);
	  }

	  public virtual DepthMetaData MetaData
	  {
		  get
		  {
			DepthMetaData localDepthMetaData = new DepthMetaData();
			getMetaData(localDepthMetaData);
			return localDepthMetaData;
		  }
	  }
	}

}