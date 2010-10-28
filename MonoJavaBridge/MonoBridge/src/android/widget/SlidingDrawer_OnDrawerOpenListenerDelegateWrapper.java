package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SlidingDrawer_OnDrawerOpenListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.SlidingDrawer.OnDrawerOpenListener
{
	static
	{
		MonoBridge.link(SlidingDrawer_OnDrawerOpenListenerDelegateWrapper.class, "onDrawerOpened", "()V", "");

	}

	@Override
	public native void onDrawerOpened();



}
