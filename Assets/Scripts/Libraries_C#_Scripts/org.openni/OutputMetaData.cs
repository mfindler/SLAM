namespace org.openni
{

	public class OutputMetaData
	{
	  private long timestamp;
	  private int frameID;
	  private int dataSize;
	  private bool isNew;
	  private long dataPtr;

	  public virtual long Timestamp
	  {
		  get
		  {
			return this.timestamp;
		  }
		  set
		  {
			this.timestamp = value;
		  }
	  }


	  public virtual int FrameID
	  {
		  get
		  {
			return this.frameID;
		  }
		  set
		  {
			this.frameID = value;
		  }
	  }


	  public virtual int DataSize
	  {
		  get
		  {
			return this.dataSize;
		  }
		  set
		  {
			this.dataSize = value;
		  }
	  }


	  public virtual bool IsNew
	  {
		  get
		  {
			return this.isNew;
		  }
		  set
		  {
			this.isNew = value;
		  }
	  }


	  public virtual long DataPtr
	  {
		  get
		  {
			return this.dataPtr;
		  }
		  set
		  {
			this.dataPtr = value;
		  }
	  }

	}

}