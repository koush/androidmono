package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SearchManager_OnDismissListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.app.SearchManager.OnDismissListener
{
	static
	{
		MonoBridge.link(SearchManager_OnDismissListenerDelegateWrapper.class, "onDismiss", "()V", "");

	}

	@Override
	public native void onDismiss();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
