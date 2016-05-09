namespace org.openni
{

	public class WrapperUtils
	{
//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static void throwOnError(int paramInt) throws StatusException
	  public static void throwOnError(int paramInt)
	  {
		if (paramInt != 0)
		{
		  throw new StatusException(paramInt);
		}
	  }

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in .NET:
//ORIGINAL LINE: public static void checkEnumeration(int paramInt, EnumerationErrors paramEnumerationErrors) throws GeneralException
	  public static void checkEnumeration(int paramInt, EnumerationErrors paramEnumerationErrors)
	  {
		if (paramInt != 0)
		{
		  if ((paramEnumerationErrors != null) && (!paramEnumerationErrors.Empty))
		  {
			throw new GeneralException(paramEnumerationErrors.ToString());
		  }
		  throw new StatusException(paramInt);
		}
	  }

	  public static string getErrorMessage(int paramInt)
	  {
		string str = NativeMethods.xnGetStatusString(paramInt);
		return str;
	  }
	}

}