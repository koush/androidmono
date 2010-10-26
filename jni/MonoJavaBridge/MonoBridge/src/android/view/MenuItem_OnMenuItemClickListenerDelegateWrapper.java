package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MenuItem_OnMenuItemClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.MenuItem.OnMenuItemClickListener
{
	static
	{
		MonoBridge.link(MenuItem_OnMenuItemClickListenerDelegateWrapper.class, "onMenuItemClick", "(Landroid/view/MenuItem;)Z", "android.view.MenuItem");

	}

	@Override
	public native boolean onMenuItemClick(android.view.MenuItem arg0);



}
