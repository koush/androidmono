package android.sax;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class StartElementListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.sax.StartElementListener
{
	static
	{
		MonoBridge.link(StartElementListenerDelegateWrapper.class, "start", "(Lorg/xml/sax/Attributes;)V", "org.xml.sax.Attributes");

	}

	@Override
	public native void start(org.xml.sax.Attributes arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
