package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ValueCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.webkit.ValueCallback
{
	static
	{
		MonoBridge.link(ValueCallbackDelegateWrapper.class, "onReceiveValue", "(Ljava/lang/Object;)V", "java.lang.Object");

	}

	public native void onReceiveValue(java.lang.Object arg0);



}
