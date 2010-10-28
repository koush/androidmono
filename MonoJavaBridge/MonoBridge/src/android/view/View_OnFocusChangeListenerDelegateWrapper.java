package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnFocusChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.View.OnFocusChangeListener
{
	static
	{
		MonoBridge.link(View_OnFocusChangeListenerDelegateWrapper.class, "onFocusChange", "(Landroid/view/View;Z)V", "android.view.View,System.Boolean");

	}

	@Override
	public native void onFocusChange(android.view.View arg0,boolean arg1);



}
