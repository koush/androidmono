package com.koushikdutta.monodalvikbridge;

public final class MonoObject
{
	int myObjectId;
	MonoObject(int objectId)
	{
		myObjectId = objectId;
	}
	
	public int getObjectId()
	{
		return myObjectId;
	}

	static String myMonoJavaBridgeName = MonoBridge.createAssemblyQualifiedName("MonoJavaBridge", "MonoJavaBridge.JavaRuntime");
	
	public void invoke(String methodName, Object... args) throws Exception
	{
		MonoBridge.invoke(null, myObjectId, false, void.class, methodName, args, null);
	}	
	
	public void invoke(Class returnType, String methodName, Object[] args, byte[] runtimeTypes) throws Exception
	{
		MonoBridge.invoke(null, myObjectId, false, returnType, methodName, args, runtimeTypes);
	}
	
	@Override
	protected void finalize() throws Throwable
	{
		super.finalize();
		MonoBridge.invoke(myMonoJavaBridgeName, "RemoveMonoReference", myObjectId);
	}
}