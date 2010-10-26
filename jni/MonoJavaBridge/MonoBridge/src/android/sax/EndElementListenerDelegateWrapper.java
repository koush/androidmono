package android.sax;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class EndElementListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.sax.EndElementListener
{
	static
	{
		MonoBridge.link(EndElementListenerDelegateWrapper.class, "end", "()V", "");

	}

	@Override
	public native void end();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
