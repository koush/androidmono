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


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
