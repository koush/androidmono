package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SlidingDrawer_OnDrawerCloseListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.SlidingDrawer.OnDrawerCloseListener
{
	static
	{
		MonoBridge.link(SlidingDrawer_OnDrawerCloseListenerDelegateWrapper.class, "onDrawerClosed", "()V", "");

	}

	public native void onDrawerClosed();



}
