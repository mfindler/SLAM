using System;
using System.Collections.Generic;

namespace org.openni
{

	public class Context : ObjectWrapper
	{
	  private Observable<ErrorStateEventArgs> errorStateChangedEvent;
	  private Observable<NodeCreatedEventArgs> nodeCreatedEvent;
	  private Observable<NodeDestroyedEventArgs> nodeDestroyedEvent;

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Context() throws GeneralException
	  public Context() : this(init(), false)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Context createFromXmlFile(String paramString, OutArg<ScriptNode> paramOutArg) throws GeneralException
	  public static Context createFromXmlFile(string paramString, OutArg<ScriptNode> paramOutArg)
	  {
		OutArg localOutArg = new OutArg();
		long l = initFromXmlEx(paramString, localOutArg);
		Context localContext = new Context(l, false);
		paramOutArg.value = new ScriptNode(localContext, ((long?)localOutArg.value).Value, false);
		return localContext;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Context fromNative(long paramLong) throws GeneralException
	  public static Context fromNative(long paramLong)
	  {
		lock (allContexts)
		{
		  if (allContexts.ContainsKey(Convert.ToInt64(paramLong)))
		  {
			return (Context)allContexts[Convert.ToInt64(paramLong)];
		  }
		  return new Context(paramLong);
		}
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static Version getVersion() throws StatusException
	  public static Version Version
	  {
		  get
		  {
			OutArg localOutArg = new OutArg();
			int i = NativeMethods.xnGetVersion(localOutArg);
			WrapperUtils.throwOnError(i);
			return (Version)localOutArg.value;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ScriptNode runXmlScriptFromFile(String paramString) throws GeneralException
	  public virtual ScriptNode runXmlScriptFromFile(string paramString)
	  {
		EnumerationErrors localEnumerationErrors = new EnumerationErrors();
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnContextRunXmlScriptFromFileEx(toNative(), paramString, localEnumerationErrors.toNative(), localOutArg);
		WrapperUtils.checkEnumeration(i, localEnumerationErrors);
		return new ScriptNode(this, ((long?)localOutArg.value).Value, false);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ScriptNode runXmlScript(String paramString) throws GeneralException
	  public virtual ScriptNode runXmlScript(string paramString)
	  {
		EnumerationErrors localEnumerationErrors = new EnumerationErrors();
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnContextRunXmlScriptEx(toNative(), paramString, localEnumerationErrors.toNative(), localOutArg);
		WrapperUtils.checkEnumeration(i, localEnumerationErrors);
		return new ScriptNode(this, ((long?)localOutArg.value).Value, false);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public Player openFileRecordingEx(String paramString) throws GeneralException
	  public virtual Player openFileRecordingEx(string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnContextOpenFileRecordingEx(toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		return (Player)createProductionNodeFromNative(((long?)localOutArg.value).Value);
	  }

	  public virtual void release()
	  {
		dispose();
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addLicense(License paramLicense) throws StatusException
	  public virtual void addLicense(License paramLicense)
	  {
		int i = NativeMethods.xnAddLicense(toNative(), paramLicense.Vendor, paramLicense.Key);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public License[] enumerateLicenses() throws StatusException
	  public virtual License[] enumerateLicenses()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerateLicenses(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return (License[])localOutArg.value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfoList enumerateProductionTrees(NodeType paramNodeType, Query paramQuery) throws GeneralException
	  public virtual NodeInfoList enumerateProductionTrees(NodeType paramNodeType, Query paramQuery)
	  {
		EnumerationErrors localEnumerationErrors = new EnumerationErrors();
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerateProductionTrees(toNative(), paramNodeType.toNative(), paramQuery == null ? 0L : paramQuery.toNative(), localOutArg, localEnumerationErrors.toNative());

		WrapperUtils.checkEnumeration(i, localEnumerationErrors);
		return new NodeInfoList(((long?)localOutArg.value).Value);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfoList enumerateProductionTrees(NodeType paramNodeType) throws GeneralException
	  public virtual NodeInfoList enumerateProductionTrees(NodeType paramNodeType)
	  {
		return enumerateProductionTrees(paramNodeType, null);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ProductionNode createProductionTree(NodeInfo paramNodeInfo) throws GeneralException
	  public virtual ProductionNode createProductionTree(NodeInfo paramNodeInfo)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateProductionTree(toNative(), paramNodeInfo.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return createProductionNodeObject(((long?)localOutArg.value).Value);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ProductionNode createAnyProductionTree(NodeType paramNodeType, Query paramQuery) throws GeneralException
	  public virtual ProductionNode createAnyProductionTree(NodeType paramNodeType, Query paramQuery)
	  {
		EnumerationErrors localEnumerationErrors = new EnumerationErrors();
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnCreateAnyProductionTree(toNative(), paramNodeType.toNative(), paramQuery == null ? 0L : paramQuery.toNative(), localOutArg, localEnumerationErrors.toNative());

		WrapperUtils.checkEnumeration(i, localEnumerationErrors);
		return createProductionNodeFromNative(((long?)localOutArg.value).Value);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfoList enumerateExistingNodes() throws GeneralException
	  public virtual NodeInfoList enumerateExistingNodes()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerateExistingNodes(toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return new NodeInfoList(((long?)localOutArg.value).Value);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfoList enumerateExistingNodes(NodeType paramNodeType) throws GeneralException
	  public virtual NodeInfoList enumerateExistingNodes(NodeType paramNodeType)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnEnumerateExistingNodesByType(toNative(), paramNodeType.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		return new NodeInfoList(((long?)localOutArg.value).Value);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ProductionNode findExistingNode(NodeType paramNodeType) throws GeneralException
	  public virtual ProductionNode findExistingNode(NodeType paramNodeType)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnFindExistingRefNodeByType(toNative(), paramNodeType.toNative(), localOutArg);
		WrapperUtils.throwOnError(i);
		ProductionNode localProductionNode = createProductionNodeObject(((long?)localOutArg.value).Value, paramNodeType);

		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);

		return localProductionNode;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public ProductionNode getProductionNodeByName(String paramString) throws GeneralException
	  public virtual ProductionNode getProductionNodeByName(string paramString)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnGetRefNodeHandleByName(toNative(), paramString, localOutArg);
		WrapperUtils.throwOnError(i);
		ProductionNode localProductionNode = createProductionNodeObject(((long?)localOutArg.value).Value);

		NativeMethods.xnProductionNodeRelease(((long?)localOutArg.value).Value);

		return localProductionNode;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public NodeInfo getProductionNodeInfoByName(String paramString) throws GeneralException
	  public virtual NodeInfo getProductionNodeInfoByName(string paramString)
	  {
		return getProductionNodeByName(paramString).Info;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void startGeneratingAll() throws StatusException
	  public virtual void startGeneratingAll()
	  {
		int i = NativeMethods.xnStartGeneratingAll(toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void stopGeneratingAll() throws StatusException
	  public virtual void stopGeneratingAll()
	  {
		int i = NativeMethods.xnStopGeneratingAll(toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool GlobalMirror
	  {
		  get
		  {
			return NativeMethods.xnGetGlobalMirror(toNative());
		  }
		  set
		  {
			int i = NativeMethods.xnSetGlobalMirror(toNative(), value);
			WrapperUtils.throwOnError(i);
		  }
	  }


//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void waitAndUpdateAll() throws StatusException
	  public virtual void waitAndUpdateAll()
	  {
		int i = NativeMethods.xnWaitAndUpdateAll(toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void waitOneUpdateAll(ProductionNode paramProductionNode) throws StatusException
	  public virtual void waitOneUpdateAll(ProductionNode paramProductionNode)
	  {
		int i = NativeMethods.xnWaitOneUpdateAll(toNative(), paramProductionNode.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void waitAnyUpdateAll() throws StatusException
	  public virtual void waitAnyUpdateAll()
	  {
		int i = NativeMethods.xnWaitAnyUpdateAll(toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void waitNoneUpdateAll() throws StatusException
	  public virtual void waitNoneUpdateAll()
	  {
		int i = NativeMethods.xnWaitNoneUpdateAll(toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual IObservable<ErrorStateEventArgs> ErrorStateChangedEvent
	  {
		  get
		  {
			return this.errorStateChangedEvent;
		  }
	  }

	  public virtual IObservable<NodeCreatedEventArgs> NodeCreatedEvent
	  {
		  get
		  {
			return this.nodeCreatedEvent;
		  }
	  }

	  public virtual IObservable<NodeDestroyedEventArgs> NodeDestroyedEvent
	  {
		  get
		  {
			return this.nodeDestroyedEvent;
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static ProductionNode createProductionNodeFromNative(long paramLong) throws GeneralException
	  public static ProductionNode createProductionNodeFromNative(long paramLong)
	  {
		long l = NativeMethods.xnGetRefContextFromNodeHandle(paramLong);
		Context localContext = fromNative(l);
		NativeMethods.xnContextRelease(l);
		return localContext.createProductionNodeObject(paramLong);
	  }

	  protected internal virtual void freeObject(long paramLong)
	  {
		lock (allContexts)
		{
		  allContexts.Remove(Convert.ToInt64(paramLong));
		}
		NativeMethods.xnContextRelease(paramLong);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private Context(long paramLong, boolean paramBoolean) throws GeneralException
	  private Context(long paramLong, bool paramBoolean) : base(paramLong)
	  {

		this.errorStateChangedEvent = new ObservableAnonymousInnerClassHelper(this);
		this.nodeCreatedEvent = new ObservableAnonymousInnerClassHelper2(this);
		this.nodeDestroyedEvent = new ObservableAnonymousInnerClassHelper3(this);
		lock (allContexts)
		{
		  if (allContexts.ContainsKey(Convert.ToInt64(paramLong)))
		  {
			throw new GeneralException("Java wrapper: creating a Context object wrapping an already wrapped object!");
		  }
		  allContexts[Convert.ToInt64(paramLong)] = this;
		}
		if (paramBoolean)
		{
		  WrapperUtils.throwOnError(NativeMethods.xnContextAddRef(paramLong));
		}
	  }

	  private class ObservableAnonymousInnerClassHelper : Observable
	  {
		  private readonly Context outerInstance;

		  public ObservableAnonymousInnerClassHelper(Context outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToGlobalErrorStateChange(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromGlobalErrorStateChange(outerInstance.toNative(), paramAnonymousLong);
		  }

		  public virtual void callback(int paramAnonymousInt)
		  {
			this.notify(new ErrorStateEventArgs(paramAnonymousInt));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper2 : Observable
	  {
		  private readonly Context outerInstance;

		  public ObservableAnonymousInnerClassHelper2(Context outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToNodeCreation(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromNodeCreation(outerInstance.toNative(), paramAnonymousLong);
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void callback(long paramAnonymousLong) throws GeneralException
		  public virtual void callback(long paramAnonymousLong)
		  {
			ProductionNode localProductionNode = outerInstance.createProductionNodeObject(paramAnonymousLong);
			this.notify(new NodeCreatedEventArgs(localProductionNode));
		  }
	  }

	  private class ObservableAnonymousInnerClassHelper3 : Observable
	  {
		  private readonly Context outerInstance;

		  public ObservableAnonymousInnerClassHelper3(Context outerInstance)
		  {
			  this.outerInstance = outerInstance;
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected int registerNative(OutArg<Nullable<long>> paramAnonymousOutArg) throws StatusException
		  protected internal virtual int registerNative(OutArg<long?> paramAnonymousOutArg)
		  {
			return NativeMethods.xnRegisterToNodeDestruction(outerInstance.toNative(), this, "callback", paramAnonymousOutArg);
		  }

		  protected internal virtual void unregisterNative(long paramAnonymousLong)
		  {
			NativeMethods.xnUnregisterFromNodeDestruction(outerInstance.toNative(), paramAnonymousLong);
		  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void callback(String paramAnonymousString) throws GeneralException
		  public virtual void callback(string paramAnonymousString)
		  {
			this.notify(new NodeDestroyedEventArgs(paramAnonymousString));
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private Context(long paramLong) throws GeneralException
	  private Context(long paramLong) : this(paramLong, true)
	  {
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private static long init() throws StatusException
	  private static long init()
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnInit(localOutArg);
		WrapperUtils.throwOnError(i);
		return ((long?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: private static long initFromXmlEx(String paramString, OutArg<Nullable<long>> paramOutArg) throws StatusException
	  private static long initFromXmlEx(string paramString, OutArg<long?> paramOutArg)
	  {
		OutArg localOutArg = new OutArg();
		int i = NativeMethods.xnInitFromXmlFileEx(paramString, localOutArg, 0L, paramOutArg);
		WrapperUtils.throwOnError(i);
		return ((long?)localOutArg.value).Value;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: ProductionNode createProductionNodeObject(long paramLong, NodeType paramNodeType) throws GeneralException
	  internal virtual ProductionNode createProductionNodeObject(long paramLong, NodeType paramNodeType)
	  {
		object localObject;
		if (paramNodeType.Equals(NodeType.DEVICE))
		{
		  localObject = new Device(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.DEPTH))
		{
		  localObject = new DepthGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.IMAGE))
		{
		  localObject = new ImageGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.AUDIO))
		{
		  localObject = new AudioGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.IR))
		{
		  localObject = new IRGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.USER))
		{
		  localObject = new UserGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.RECORDER))
		{
		  localObject = new Recorder(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.PLAYER))
		{
		  localObject = new Player(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.GESTURE))
		{
		  localObject = new GestureGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.SCENE))
		{
		  localObject = new SceneAnalyzer(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.HANDS))
		{
		  localObject = new HandsGenerator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.CODEC))
		{
		  localObject = new Codec(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.SCRIPT_NODE))
		{
		  localObject = new ScriptNode(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.PRODUCTION_NODE))
		{
		  localObject = new ProductionNode(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.GENERATOR))
		{
		  localObject = new Generator(this, paramLong, true);
		}
		else if (paramNodeType.Equals(NodeType.MAP_GENERATOR))
		{
		  localObject = new MapGenerator(this, paramLong, true);
		}
		else
		{
		  throw new GeneralException("java wrapper: Unknown generator type!");
		}
		return (ProductionNode)localObject;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: ProductionNode createProductionNodeObject(long paramLong) throws GeneralException
	  internal virtual ProductionNode createProductionNodeObject(long paramLong)
	  {
		long l = NativeMethods.xnGetNodeInfo(paramLong);
		NodeType localNodeType = NativeMethods.xnNodeInfoGetDescription(l).Type;
		return createProductionNodeObject(paramLong, localNodeType);
	  }

	  private static Dictionary<long?, Context> allContexts = new Hashtable();
	}

}