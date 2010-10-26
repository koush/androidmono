package android.sax;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class EndElementListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.sax.EndElementListener
{
	static
	{
		MonoBridge.link(EndElementListenerDelegateWrapper.class, "end", "()V", "");

	}

	@Override
	public native void end();



}
