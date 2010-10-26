package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WebStorage_QuotaUpdaterDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.WebStorage.QuotaUpdater
{
	static
	{
		MonoBridge.link(WebStorage_QuotaUpdaterDelegateWrapper.class, "updateQuota", "(J)V", "System.Int64");

	}

	@Override
	public native void updateQuota(long arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
