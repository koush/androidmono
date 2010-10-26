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
