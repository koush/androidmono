package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WebStorage_QuotaUpdaterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.webkit.WebStorage.QuotaUpdater
{
	static
	{
		MonoBridge.link(WebStorage_QuotaUpdaterDelegateWrapper.class, "updateQuota", "(J)V", "System.Int64");

	}

	@Override
	public native void updateQuota(long arg0);



}
