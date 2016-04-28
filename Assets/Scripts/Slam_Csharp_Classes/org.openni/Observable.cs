using System.Collections;
using System.Collections.Generic;

namespace org.openni
{

	public abstract class Observable<Args> : IObservable<Args>
	{
	  private List<IObserver<Args>> observers;
	  private long hCallback;

	  public Observable()
	  {
		this.observers = new ArrayList();
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public void addObserver(IObserver<Args> paramIObserver) throws StatusException
	  public virtual void addObserver(IObserver<Args> paramIObserver)
	  {
		if (this.observers.Count == 0)
		{
		  OutArg localOutArg = new OutArg();
		  int i = registerNative(localOutArg);
		  WrapperUtils.throwOnError(i);
		  this.hCallback = ((long?)localOutArg.value).Value;
		}
		this.observers.Add(paramIObserver);
	  }

	  public virtual void deleteObserver(IObserver<Args> paramIObserver)
	  {
		this.observers.Remove(paramIObserver);
		if (this.observers.Count == 0)
		{
		  unregisterNative(this.hCallback);
		}
	  }

	  public virtual void notify(Args paramArgs)
	  {
		foreach (IObserver localIObserver in this.observers)
		{
		  localIObserver.update(this, paramArgs);
		}
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: protected abstract int registerNative(OutArg<Nullable<long>> paramOutArg) throws StatusException;
	  protected internal abstract int registerNative(OutArg<long?> paramOutArg);

	  protected internal abstract void unregisterNative(long paramLong);
	}

}