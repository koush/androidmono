package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PreferenceManager_OnActivityDestroyListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.preference.PreferenceManager.OnActivityDestroyListener
{
	static
	{
		MonoBridge.link(PreferenceManager_OnActivityDestroyListenerDelegateWrapper.class, "onActivityDestroy", "()V", "");

	}

	@Override
	public native void onActivityDestroy();


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
