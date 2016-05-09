using System.Collections.Generic;

namespace org.openni
{


	public class NodeInfoList : ObjectWrapper, IEnumerable<NodeInfo>
	{
	  private bool own;

	  internal NodeInfoList(long paramLong, bool paramBoolean) : base(paramLong)
	  {
		this.own = paramBoolean;
	  }

	  internal NodeInfoList(long paramLong) : base(paramLong)
	  {
		this.own = true;
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void add(ProductionNodeDescription paramProductionNodeDescription, String paramString, NodeInfoList paramNodeInfoList) throws StatusException
	  public virtual void add(ProductionNodeDescription paramProductionNodeDescription, string paramString, NodeInfoList paramNodeInfoList)
	  {
		long l = paramProductionNodeDescription.createNative();
		int i = NativeMethods.xnNodeInfoListAdd(toNative(), l, paramString, paramNodeInfoList == null ? 0L : paramNodeInfoList.toNative());

		ProductionNodeDescription.freeNative(l);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addNode(NodeInfo paramNodeInfo) throws StatusException
	  public virtual void addNode(NodeInfo paramNodeInfo)
	  {
		int i = NativeMethods.xnNodeInfoListAddNode(toNative(), paramNodeInfo.toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addNodeFromList(java.util.Iterator<NodeInfo> paramIterator) throws StatusException
	  public virtual void addNodeFromList(IEnumerator<NodeInfo> paramIterator)
	  {
		NodeInfoListIterator localNodeInfoListIterator = (NodeInfoListIterator)paramIterator;
		int i = NativeMethods.xnNodeInfoListAddNodeFromList(toNative(), localNodeInfoListIterator.it);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void remove(java.util.Iterator<NodeInfo> paramIterator) throws StatusException
	  public virtual void remove(IEnumerator<NodeInfo> paramIterator)
	  {
		NodeInfoListIterator localNodeInfoListIterator = (NodeInfoListIterator)paramIterator;
		int i = NativeMethods.xnNodeInfoListRemove(toNative(), localNodeInfoListIterator.it);
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void clear() throws StatusException
	  public virtual void clear()
	  {
		int i = NativeMethods.xnNodeInfoListClear(toNative());
		WrapperUtils.throwOnError(i);
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void append(NodeInfoList paramNodeInfoList) throws StatusException
	  public virtual void append(NodeInfoList paramNodeInfoList)
	  {
		int i = NativeMethods.xnNodeInfoListAppend(toNative(), paramNodeInfoList.toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual bool Empty
	  {
		  get
		  {
			return NativeMethods.xnNodeInfoListIsEmpty(toNative());
		  }
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void filter(Query paramQuery, Context paramContext) throws StatusException
	  public virtual void filter(Query paramQuery, Context paramContext)
	  {
		int i = NativeMethods.xnNodeQueryFilterList(paramContext.toNative(), paramQuery.toNative(), toNative());
		WrapperUtils.throwOnError(i);
	  }

	  public virtual IEnumerator<NodeInfo> GetEnumerator()
	  {
		return new NodeInfoListIterator(this, toNative());
	  }

	  protected internal virtual void freeObject(long paramLong)
	  {
		if (this.own)
		{
		  NativeMethods.xnNodeInfoListFree(paramLong);
		}
	  }

	  private class NodeInfoListIterator : IEnumerator<NodeInfo>
	  {
		  private readonly NodeInfoList outerInstance;

		protected internal long it;

		internal NodeInfoListIterator(NodeInfoList outerInstance, long paramLong)
		{
			this.outerInstance = outerInstance;
		  this.it = NativeMethods.xnNodeInfoListGetFirst(paramLong);
		}

		public virtual bool hasNext()
		{
		  return NativeMethods.xnNodeInfoListIteratorIsValid(this.it);
		}

		public virtual NodeInfo next()
		{
		  if (!hasNext())
		  {
			throw new NoSuchElementException();
		  }
		  NodeInfo localNodeInfo = null;
		  try
		  {
			localNodeInfo = new NodeInfo(NativeMethods.xnNodeInfoListGetCurrent(this.it));
		  }
		  catch (GeneralException)
		  {
		  }
		  this.it = NativeMethods.xnNodeInfoListGetNext(this.it);
		  return localNodeInfo;
		}

		public virtual void remove()
		{
		  throw new System.NotSupportedException();
		}
	  }
	}

}