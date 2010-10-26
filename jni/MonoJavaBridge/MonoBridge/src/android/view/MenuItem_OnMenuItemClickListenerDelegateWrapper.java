package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MenuItem_OnMenuItemClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.MenuItem.OnMenuItemClickListener
{
	static
	{
		MonoBridge.link(MenuItem_OnMenuItemClickListenerDelegateWrapper.class, "onMenuItemClick", "(Landroid/view/MenuItem;)Z", "android.view.MenuItem");

	}

	@Override
	public native boolean onMenuItemClick(android.view.MenuItem arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
