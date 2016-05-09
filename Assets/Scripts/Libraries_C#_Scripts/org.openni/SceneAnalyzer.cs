namespace org.openni
{

	public class SceneAnalyzer : MapGenerator
	{
	  private SceneMap currSceneMap;
	  private int currSceneMapFrameID;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: SceneAnalyzer(Context paramContext, long paramLong, boolean paramBoolean) throws GeneralException
	  internal SceneAnalyzer(Context paramContext, long paramLong, bool paramBoolean) : base(paramContext, paramLong, paramBoolean)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static SceneAnalyzer create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static SceneAnalyzer create(Context paramContext, Query paramQuery, EnumerationErrors paramEnumerationErrors)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateSceneAnalyzer(paramContext.toNative(), localOutArg, paramQuery == null ? 0L : paramQuery.toNative(), paramEnumerationErrors == null ? 0L : paramEnumerationErrors.toNative());

		WrapperUtils.throwOnError(i);
		SceneAnalyzer localSceneAnalyzer = (SceneAnalyzer)paramContext.createProductionNodeObject(((long?)localOutArg.value).Value, NodeType.SCENE);
		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);
		return localSceneAnalyzer;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static SceneAnalyzer create(Context paramContext, Query paramQuery) throws GeneralException
	  public static SceneAnalyzer create(Context paramContext, Query paramQuery)
	  {
		return create(paramContext, paramQuery, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static SceneAnalyzer create(Context paramContext) throws GeneralException
	  public static SceneAnalyzer create(Context paramContext)
	  {
		return create(paramContext, null, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public SceneMap getSceneMap() throws GeneralException
	  public virtual SceneMap SceneMap
	  {
		  get
		  {
			int i = FrameID;
			if ((this.currSceneMap == null) || (this.currSceneMapFrameID != i))
			{
			  long l = NativeMethods.xnGetLabelMap(toNative());
			  MapOutputMode localMapOutputMode = MapOutputMode;
			  this.currSceneMap = new SceneMap(l, localMapOutputMode.XRes, localMapOutputMode.YRes);
			  this.currSceneMapFrameID = i;
			}
			return this.currSceneMap;
		  }
	  }

	  public virtual void getMetaData(SceneMetaData paramSceneMetaData)
	  {
		NativeMethods.xnGetSceneMetaData(toNative(), paramSceneMetaData);
	  }

	  public virtual SceneMetaData MetaData
	  {
		  get
		  {
			SceneMetaData localSceneMetaData = new SceneMetaData();
			getMetaData(localSceneMetaData);
			return localSceneMetaData;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Plane3D getFloor() throws StatusException
	  public virtual Plane3D Floor
	  {
		  get
		  {
			OutArg localOutArg1 = new OutArg();
			OutArg localOutArg2 = new OutArg();
    
			int i = NativeMethods.xnGetFloor(toNative(), localOutArg1, localOutArg2);
			WrapperUtils.throwOnError(i);
			return new Plane3D((Point3D)localOutArg1.value, (Point3D)localOutArg2.value);
		  }
	  }
	}

}