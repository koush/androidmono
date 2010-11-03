package android.sax;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class StartElementListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.sax.StartElementListener
{
	static
	{
		MonoBridge.link(StartElementListenerDelegateWrapper.class, "start", "(Lorg/xml/sax/Attributes;)V", "org.xml.sax.Attributes");

	}

	public native void start(org.xml.sax.Attributes arg0);



}
