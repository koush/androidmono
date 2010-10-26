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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
