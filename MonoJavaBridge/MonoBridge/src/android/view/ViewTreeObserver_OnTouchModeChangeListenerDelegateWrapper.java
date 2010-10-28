package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnTouchModeChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.ViewTreeObserver.OnTouchModeChangeListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnTouchModeChangeListenerDelegateWrapper.class, "onTouchModeChanged", "(Z)V", "System.Boolean");

	}

	@Override
	public native void onTouchModeChanged(boolean arg0);



}
