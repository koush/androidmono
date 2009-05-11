package com.koushikdutta.monodalvikbridge;

public final class MonoObject
{
	int myObjectId;
	MonoObject(int objectId)
	{
		myObjectId = objectId;
	}

	static String myMonoJavaBridgeName = MonoBridge.createAssemblyQualifiedName("MonoJavaBridge", "MonoJavaBridge.JavaRuntime");
	
	public void invoke(String methodName, Object... args) throws Exception
	{
		MonoBridge.invoke(null, myObjectId, false, void.class, methodName, args, null);
	}
	
	@Override
	protected void finalize() throws Throwable
	{
		super.finalize();
		MonoBridge.invoke(myMonoJavaBridgeName, "RemoveMonoReference", myObjectId);
	}
}