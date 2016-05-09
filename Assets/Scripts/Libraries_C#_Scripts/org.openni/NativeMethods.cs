using System.Runtime.InteropServices;

namespace org.openni
{


	internal class NativeMethods
	{
//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern byte readByte(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern short readShort(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int readInt(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long readLong(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void copyToBuffer(ByteBuffer paramByteBuffer, long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long createProductionNodeDescription(int paramInt1, string paramString1, string paramString2, sbyte paramByte1, sbyte paramByte2, short paramShort, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void freeProductionNodeDescription(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnGetStatusString(int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnInit(OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnContextRunXmlScriptFromFileEx(long paramLong1, string paramString, long paramLong2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnContextRunXmlScriptEx(long paramLong1, string paramString, long paramLong2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnInitFromXmlFileEx(string paramString, OutArg<long?> paramOutArg1, long paramLong, OutArg<long?> paramOutArg2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnContextOpenFileRecordingEx(long paramLong, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnContextAddRef(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnContextRelease(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerateProductionTrees(long paramLong1, int paramInt, long paramLong2, OutArg<long?> paramOutArg, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateProductionTree(long paramLong1, long paramLong2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateAnyProductionTree(long paramLong1, int paramInt, long paramLong2, OutArg<long?> paramOutArg, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerateExistingNodes(long paramLong, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerateExistingNodesByType(long paramLong, int paramInt, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnFindExistingRefNodeByType(long paramLong, int paramInt, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetRefNodeHandleByName(long paramLong, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnWaitAndUpdateAll(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnWaitOneUpdateAll(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnWaitAnyUpdateAll(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnWaitNoneUpdateAll(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStartGeneratingAll(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopGeneratingAll(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetGlobalMirror(long paramLong, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnGetGlobalMirror(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetGlobalErrorState(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToGlobalErrorStateChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromGlobalErrorStateChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToNodeCreation(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromNodeCreation(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToNodeDestruction(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromNodeDestruction(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnAddLicense(long paramLong, string paramString1, string paramString2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerateLicenses(long paramLong, OutArg<License[]> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerationErrorsAllocate(OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnEnumerationErrorsFree(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerationErrorsToString(long paramLong, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerationErrorsClear(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnEnumerationErrorsGetFirst(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnEnumerationErrorsIteratorIsValid(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoSetInstanceName(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern ProductionNodeDescription xnNodeInfoGetDescription(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoGetTreeStringRepresentation(long paramLong, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnNodeInfoGetInstanceName(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnNodeInfoGetCreationInfo(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnNodeInfoGetNeededNodes(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnNodeInfoGetRefHandle(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListAllocate(OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnNodeInfoListFree(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListAdd(long paramLong1, long paramLong2, string paramString, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListAddNode(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListAddNodeFromList(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListRemove(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListClear(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeInfoListAppend(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnNodeInfoListIsEmpty(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnNodeInfoListGetFirst(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnNodeInfoListIteratorIsValid(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnNodeInfoListGetCurrent(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnNodeInfoListGetNext(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQueryAllocate(OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnNodeQueryFree(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetVendor(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetName(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetMinVersion(long paramLong, sbyte paramByte1, sbyte paramByte2, short paramShort, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetMaxVersion(long paramLong, sbyte paramByte1, sbyte paramByte2, short paramShort, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQueryAddSupportedCapability(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQueryAddSupportedMapOutputMode(long paramLong, int paramInt1, int paramInt2, int paramInt3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetSupportedMinUserPositions(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetExistingNodeOnly(long paramLong, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetNonExistingNodeOnly(long paramLong, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQueryAddNeededNode(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQuerySetCreationInfo(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnNodeQueryFilterList(long paramLong1, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnProductionNodeAddRef(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnProductionNodeRelease(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetNodeInfo(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnGetNodeName(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetRefContextFromNodeHandle(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsCapabilitySupported(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetIntProperty(long paramLong1, string paramString, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetRealProperty(long paramLong, string paramString, double paramDouble);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetStringProperty(long paramLong, string paramString1, string paramString2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetGeneralProperty(long paramLong1, string paramString, int paramInt, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetGeneralPropertyArray(long paramLong, string paramString, sbyte[] paramArrayOfByte);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetIntProperty(long paramLong, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetRealProperty(long paramLong, string paramString, OutArg<double?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetStringProperty(long paramLong, string paramString, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetGeneralProperty(long paramLong1, string paramString, int paramInt, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetGeneralPropertyArray(long paramLong, string paramString, sbyte[] paramArrayOfByte);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLockNodeForChanges(long paramLong, OutArg<int?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnUnlockNodeForChanges(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLockedNodeStartChanges(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLockedNodeEndChanges(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnAddNeededNode(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRemoveNeededNode(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateDevice(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetDeviceName(long paramLong, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetVendorSpecificData(long paramLong, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSerialNumber(long paramLong, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetNodeErrorState(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToNodeErrorStateChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromNodeErrorStateChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetGeneralIntRange(long paramLong, string paramString, OutArg<int?> paramOutArg1, OutArg<int?> paramOutArg2, OutArg<int?> paramOutArg3, OutArg<int?> paramOutArg4, OutArg<bool?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetGeneralIntValue(long paramLong, string paramString, OutArg<int?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetGeneralIntValue(long paramLong, string paramString, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToGeneralIntValueChange(long paramLong, string paramString1, object paramObject, string paramString2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromGeneralIntValueChange(long paramLong1, string paramString, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStartGenerating(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsGenerating(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopGenerating(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToGenerationRunningChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromGenerationRunningChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToNewDataAvailable(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromNewDataAvailable(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsNewDataAvailable(long paramLong, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnWaitAndUpdateData(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsDataNew(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetData(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetDataSize(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetTimestamp(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetFrameID(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetMirror(long paramLong, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsMirrored(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToMirrorChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromMirrorChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsViewPointSupported(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetViewPoint(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnResetViewPoint(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsViewPointAs(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToViewPointChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromViewPointChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetPixelCoordinatesInViewPoint(long paramLong1, long paramLong2, int paramInt1, int paramInt2, OutArg<int?> paramOutArg1, OutArg<int?> paramOutArg2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnCanFrameSyncWith(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnFrameSyncWith(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopFrameSyncWith(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsFrameSyncedWith(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToFrameSyncChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromFrameSyncChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSupportedMapOutputModesCount(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSupportedMapOutputModes(long paramLong, MapOutputMode[] paramArrayOfMapOutputMode);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetMapOutputMode(long paramLong, int paramInt1, int paramInt2, int paramInt3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetMapOutputMode(long paramLong, OutArg<int?> paramOutArg1, OutArg<int?> paramOutArg2, OutArg<int?> paramOutArg3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToMapOutputModeChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromMapOutputModeChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetBytesPerPixel(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetCropping(long paramLong, int paramInt1, int paramInt2, int paramInt3, int paramInt4, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetCropping(long paramLong, OutArg<int?> paramOutArg1, OutArg<int?> paramOutArg2, OutArg<int?> paramOutArg3, OutArg<int?> paramOutArg4, OutArg<bool?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToCroppingChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromCroppingChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetPowerLineFrequency(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetPowerLineFrequency(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToPowerLineFrequencyChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromPowerLineFrequencyChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateDepthGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern short xnGetDeviceMaxDepth(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetDepthFieldOfView(long paramLong, OutArg<double?> paramOutArg1, OutArg<double?> paramOutArg2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToDepthFieldOfViewChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromDepthFieldOfViewChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnConvertProjectiveToRealWorld(long paramLong, Point3D[] paramArrayOfPoint3D1, Point3D[] paramArrayOfPoint3D2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnConvertRealWorldToProjective(long paramLong, Point3D[] paramArrayOfPoint3D1, Point3D[] paramArrayOfPoint3D2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetDepthMap(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnGetDepthMetaData(long paramLong, DepthMetaData paramDepthMetaData);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSupportedUserPositionsCount(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetUserPosition(long paramLong, int paramInt, float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4, float paramFloat5, float paramFloat6);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetUserPosition(long paramLong, int paramInt, OutArg<BoundingBox3D> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToUserPositionChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromUserPositionChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateImageGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetImageMap(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsPixelFormatSupported(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetPixelFormat(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetPixelFormat(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToPixelFormatChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromPixelFormatChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnGetImageMetaData(long paramLong, ImageMetaData paramImageMetaData);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateIRGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetIRMap(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnGetIRMetaData(long paramLong, IRMetaData paramIRMetaData);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateGestureGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnAddGesture(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnAddGesture(long paramLong, string paramString, float paramFloat1, float paramFloat2, float paramFloat3, float paramFloat4, float paramFloat5, float paramFloat6);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRemoveGesture(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetAllActiveGestures(long paramLong, OutArg<String[]> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetNumberOfAvailableGestures(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerateAllGestures(long paramLong, OutArg<String[]> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsGestureAvailable(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsGestureProgressSupported(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterGestureCallbacks(long paramLong, object paramObject, string paramString1, string paramString2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterGestureCallbacks(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToGestureChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromGestureChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToGestureIntermediateStageCompleted(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromGestureIntermediateStageCompleted(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToGestureReadyForNextIntermediateStage(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromGestureReadyForNextIntermediateStage(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateSceneAnalyzer(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetLabelMap(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetFloor(long paramLong, OutArg<Point3D> paramOutArg1, OutArg<Point3D> paramOutArg2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnGetSceneMetaData(long paramLong, SceneMetaData paramSceneMetaData);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateUserGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetNumberOfUsers(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetUsers(long paramLong, OutArg<int?[]> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetUserCoM(long paramLong, int paramInt, OutArg<Point3D> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetUserPixels(long paramLong, int paramInt, SceneMetaData paramSceneMetaData);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterUserCallbacks(long paramLong, object paramObject, string paramString1, string paramString2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterUserCallbacks(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToUserExit(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromUserExit(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToUserReEnter(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromUserReEnter(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsJointAvailable(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsProfileAvailable(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetSkeletonProfile(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetJointActive(long paramLong, int paramInt, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsJointActive(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToJointConfigurationChange(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromJointConfigurationChange(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumerateActiveJoints(long paramLong, OutArg<int?[]> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSkeletonJoint(long paramLong, int paramInt1, int paramInt2, OutArg<SkeletonJointTransformation> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSkeletonJointPosition(long paramLong, int paramInt1, int paramInt2, OutArg<SkeletonJointPosition> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSkeletonJointOrientation(long paramLong, int paramInt1, int paramInt2, OutArg<SkeletonJointOrientation> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsSkeletonTracking(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsSkeletonCalibrated(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsSkeletonCalibrating(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRequestSkeletonCalibration(long paramLong, int paramInt, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnAbortSkeletonCalibration(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSaveSkeletonCalibrationDataToFile(long paramLong, int paramInt, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLoadSkeletonCalibrationDataFromFile(long paramLong, int paramInt, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSaveSkeletonCalibrationData(long paramLong, int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLoadSkeletonCalibrationData(long paramLong, int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnClearSkeletonCalibrationData(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsSkeletonCalibrationData(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStartSkeletonTracking(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopSkeletonTracking(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnResetSkeleton(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnNeedPoseForSkeletonCalibration(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSkeletonCalibrationPose(long paramLong, OutArg<String> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetSkeletonSmoothing(long paramLong, float paramFloat);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToCalibrationStart(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromCalibrationStart(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToCalibrationInProgress(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromCalibrationInProgress(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToCalibrationComplete(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromCalibrationComplete(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetNumberOfPoses(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetAllAvailablePoses(long paramLong, OutArg<String[]> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStartPoseDetection(long paramLong, string paramString, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopPoseDetection(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopSinglePoseDetection(long paramLong, int paramInt, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToPoseDetected(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromPoseDetected(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToOutOfPose(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromOutOfPose(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToPoseDetectionInProgress(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromPoseDetectionInProgress(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsPoseSupported(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetPoseStatus(long paramLong, int paramInt, string paramString, OutArg<long?> paramOutArg, OutArg<int?> paramOutArg1, OutArg<int?> paramOutArg2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateHandsGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterHandCallbacks(long paramLong, object paramObject, string paramString1, string paramString2, string paramString3, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterHandCallbacks(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopTracking(long paramLong, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStopTrackingAll(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnStartTracking(long paramLong, float paramFloat1, float paramFloat2, float paramFloat3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetTrackingSmoothing(long paramLong, float paramFloat);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToHandTouchingFOVEdge(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromHandTouchingFOVEdge(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateAudioGenerator(long paramLong1, OutArg<long?> paramOutArg, long paramLong2, long paramLong3);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern long xnGetAudioBuffer(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSupportedWaveOutputModesCount(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetSupportedWaveOutputModes(long paramLong, WaveOutputMode[] paramArrayOfWaveOutputMode);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetWaveOutputMode(long paramLong, int paramInt, short paramShort, sbyte paramByte);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetWaveOutputMode(long paramLong, OutArg<int?> paramOutArg, OutArg<short?> paramOutArg1, OutArg<sbyte?> paramOutArg2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToWaveOutputModeChanges(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromWaveOutputModeChanges(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnGetAudioMetaData(long paramLong, AudioMetaData paramAudioMetaData);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateCodec(long paramLong1, int paramInt, long paramLong2, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetCodecID(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEncodeData(long paramLong1, long paramLong2, int paramInt1, long paramLong3, int paramInt2, OutArg<int?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnDecodeData(long paramLong1, long paramLong2, int paramInt1, long paramLong3, int paramInt2, OutArg<int?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateRecorder(long paramLong, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetRecorderDestination(long paramLong, int paramInt, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetRecorderDestination(long paramLong, OutArg<int?> paramOutArg, OutArg<String> paramOutArg1);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnAddNodeToRecording(long paramLong1, long paramLong2, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRemoveNodeFromRecording(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRecord(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnGetRecorderFormat(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreatePlayer(long paramLong, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetPlayerRepeat(long paramLong, bool paramBoolean);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetPlayerSource(long paramLong, int paramInt, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetPlayerSource(long paramLong, OutArg<int?> paramOutArg, OutArg<String> paramOutArg1);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnPlayerReadNext(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSeekPlayerToTimeStamp(long paramLong1, long paramLong2, int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSeekPlayerToFrame(long paramLong, string paramString, int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnTellPlayerTimestamp(long paramLong, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnTellPlayerFrame(long paramLong, string paramString, OutArg<int?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetPlayerNumFrames(long paramLong, string paramString, OutArg<int?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnGetPlayerSupportedFormat(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnEnumeratePlayerNodes(long paramLong, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsPlayerAtEOF(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnRegisterToEndOfFileReached(long paramLong, object paramObject, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern void xnUnregisterFromEndOfFileReached(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnSetPlaybackSpeed(long paramLong, double paramDouble);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern double xnGetPlaybackSpeed(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnCreateScriptNode(long paramLong, string paramString, OutArg<long?> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnScriptNodeGetSupportedFormat(long paramLong);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLoadScriptFromFile(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnLoadScriptFromString(long paramLong, string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnScriptNodeRun(long paramLong1, long paramLong2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnProductionNodeTypeToString(int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnResolutionGetXRes(int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnResolutionGetYRes(int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnResolutionGetFromXYRes(int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnResolutionGetFromName(string paramString);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern String xnResolutionGetName(int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetVersion(OutArg<Version> paramOutArg);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsTypeGenerator(int paramInt);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern boolean xnIsTypeDerivedFrom(int paramInt1, int paramInt2);

//JAVA TO C# CONVERTER TODO TASK: Replace 'unknown' with the appropriate dll name:
	  [DllImport("unknown")]
	  internal static extern int xnGetBytesPerPixelForPixelFormat(int paramInt);

	  static NativeMethods()
	  {
		string str = System.getenv("PROCESSOR_ARCHITECTURE");
		if ((!string.ReferenceEquals(str, null)) && ((str.Equals("AMD64")) || (str.Equals("IA64"))))
		{
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		  System.loadLibrary("OpenNI.jni64");
		}
		else
		{
//JAVA TO C# CONVERTER TODO TASK: The library is specified in the 'DllImport' attribute for .NET:
//		  System.loadLibrary("OpenNI.jni");
		}
	  }
	}

}