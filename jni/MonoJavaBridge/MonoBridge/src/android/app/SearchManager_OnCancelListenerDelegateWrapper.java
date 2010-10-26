package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SearchManager_OnCancelListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.app.SearchManager.OnCancelListener
{
	static
	{
		MonoBridge.link(SearchManager_OnCancelListenerDelegateWrapper.class, "onCancel", "()V", "");

	}

	@Override
	public native void onCancel();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
