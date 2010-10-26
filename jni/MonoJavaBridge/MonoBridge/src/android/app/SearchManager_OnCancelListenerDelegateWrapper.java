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
