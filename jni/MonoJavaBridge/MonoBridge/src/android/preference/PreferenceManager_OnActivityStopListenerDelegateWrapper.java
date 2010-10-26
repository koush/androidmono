package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PreferenceManager_OnActivityStopListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.preference.PreferenceManager.OnActivityStopListener
{
	static
	{
		MonoBridge.link(PreferenceManager_OnActivityStopListenerDelegateWrapper.class, "onActivityStop", "()V", "");

	}

	@Override
	public native void onActivityStop();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
