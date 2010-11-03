package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SearchManager_OnCancelListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.app.SearchManager.OnCancelListener
{
	static
	{
		MonoBridge.link(SearchManager_OnCancelListenerDelegateWrapper.class, "onCancel", "()V", "");

	}

	public native void onCancel();



}
