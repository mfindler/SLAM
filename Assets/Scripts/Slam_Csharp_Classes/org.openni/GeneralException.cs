using System;

namespace org.openni
{

	public class GeneralException : Exception
	{
	  private const long serialVersionUID = 1L;

	  public GeneralException(string paramString) : base(paramString)
	  {
	  }
	}

}