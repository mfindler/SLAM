namespace org.openni
{

	public abstract interface IObservable<Args>
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public abstract void addObserver(IObserver<Args> paramIObserver) throws StatusException;
	  void addObserver(IObserver<Args> paramIObserver);

	  void deleteObserver(IObserver<Args> paramIObserver);
	}

}