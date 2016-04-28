namespace org.openni
{

	public abstract interface IObserver<Args>
	{
	  void update(IObservable<Args> paramIObservable, Args paramArgs);
	}

}