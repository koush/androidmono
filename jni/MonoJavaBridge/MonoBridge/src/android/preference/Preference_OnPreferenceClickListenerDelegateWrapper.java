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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
