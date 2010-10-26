package android.sax;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class EndTextElementListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.sax.EndTextElementListener
{
	static
	{
		MonoBridge.link(EndTextElementListenerDelegateWrapper.class, "end", "(Ljava/lang/String;)V", "java.lang.String");

	}

	@Override
	public native void end(java.lang.String arg0);


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
