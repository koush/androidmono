package android.test;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TestSuiteProviderDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.test.TestSuiteProvider
{
	static
	{
		MonoBridge.link(TestSuiteProviderDelegateWrapper.class, "getTestSuite", "()Ljunit/framework/TestSuite;", "");

	}

	@Override
	public native junit.framework.TestSuite getTestSuite();



}
