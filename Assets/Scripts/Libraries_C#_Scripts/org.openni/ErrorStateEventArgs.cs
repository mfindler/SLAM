namespace org.openni
{

	public class ErrorStateEventArgs : EventArgs
	{
	  private string currError;

	  public ErrorStateEventArgs(int paramInt)
	  {
		if (paramInt == 0)
		{
		  this.currError = null;
		}
		else
		{
		  this.currError = WrapperUtils.getErrorMessage(paramInt);
		}
	  }

	  public virtual string CurrentError
	  {
		  get
		  {
			return this.currError;
		  }
	  }
	}

}