package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnLongClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.View.OnLongClickListener
{
	static
	{
		MonoBridge.link(View_OnLongClickListenerDelegateWrapper.class, "onLongClick", "(Landroid/view/View;)Z", "android.view.View");

	}

	@Override
	public native boolean onLongClick(android.view.View arg0);



}
