package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnGlobalFocusChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.ViewTreeObserver.OnGlobalFocusChangeListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnGlobalFocusChangeListenerDelegateWrapper.class, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", "android.view.View,android.view.View");

	}

	@Override
	public native void onGlobalFocusChanged(android.view.View arg0,android.view.View arg1);



}
