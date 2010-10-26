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
