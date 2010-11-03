package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnGlobalLayoutListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.ViewTreeObserver.OnGlobalLayoutListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnGlobalLayoutListenerDelegateWrapper.class, "onGlobalLayout", "()V", "");

	}

	public native void onGlobalLayout();



}
