namespace org.openni
{

	public class StatusException : GeneralException
	{
	  private const long serialVersionUID = 1L;

	  public StatusException(int paramInt) : base(WrapperUtils.getErrorMessage(paramInt))
	  {
	  }
	}

}