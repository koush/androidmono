package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Preference_OnPreferenceClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.preference.Preference.OnPreferenceClickListener
{
	static
	{
		MonoBridge.link(Preference_OnPreferenceClickListenerDelegateWrapper.class, "onPreferenceClick", "(Landroid/preference/Preference;)Z", "android.preference.Preference");

	}

	@Override
	public native boolean onPreferenceClick(android.preference.Preference arg0);


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
