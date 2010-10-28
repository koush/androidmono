package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnScrollChangedListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.ViewTreeObserver.OnScrollChangedListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnScrollChangedListenerDelegateWrapper.class, "onScrollChanged", "()V", "");

	}

	@Override
	public native void onScrollChanged();



}
