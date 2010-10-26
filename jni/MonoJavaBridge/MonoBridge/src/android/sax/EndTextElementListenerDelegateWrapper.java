package android.sax;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class EndTextElementListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.sax.EndTextElementListener
{
	static
	{
		MonoBridge.link(EndTextElementListenerDelegateWrapper.class, "end", "(Ljava/lang/String;)V", "java.lang.String");

	}

	@Override
	public native void end(java.lang.String arg0);



}
