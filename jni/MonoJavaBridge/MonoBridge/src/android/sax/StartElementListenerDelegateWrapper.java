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
