namespace org.openni
{

	public abstract class StateChangedObservable : Observable<EventArgs>, IStateChangedObservable
	{
	  protected internal virtual int registerNative(OutArg<long?> paramOutArg)
	  {
		return registerNative("callback", paramOutArg);
	  }

	  protected internal abstract int registerNative(string paramString, OutArg<long?> paramOutArg);

	  private void callback()
	  {
		this.notify(null);
	  }
	}

}