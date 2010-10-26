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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
