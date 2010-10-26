package android.net;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class UrlQuerySanitizer_ValueSanitizerDelegateWrapper extends java.lang.Object implements MonoProxy, android.net.UrlQuerySanitizer.ValueSanitizer
{
	static
	{
		MonoBridge.link(UrlQuerySanitizer_ValueSanitizerDelegateWrapper.class, "sanitize", "(Ljava/lang/String;)Ljava/lang/String;", "java.lang.String");

	}

	@Override
	public native java.lang.String sanitize(java.lang.String arg0);


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
