package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ValueCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.ValueCallback
{
	static
	{
		MonoBridge.link(ValueCallbackDelegateWrapper.class, "onReceiveValue", "(Ljava/lang/Object;)V", "java.lang.Object");

	}

	@Override
	public native void onReceiveValue(java.lang.Object arg0);


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
