package android.test;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TestSuiteProviderDelegateWrapper extends java.lang.Object implements MonoProxy, android.test.TestSuiteProvider
{
	static
	{
		MonoBridge.link(TestSuiteProviderDelegateWrapper.class, "getTestSuite", "()Ljunit/framework/TestSuite;", "");

	}

	@Override
	public native junit.framework.TestSuite getTestSuite();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
