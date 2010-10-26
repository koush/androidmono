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


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
