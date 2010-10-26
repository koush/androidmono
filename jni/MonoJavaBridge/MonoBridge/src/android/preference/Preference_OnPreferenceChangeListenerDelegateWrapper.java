package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Preference_OnPreferenceChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.preference.Preference.OnPreferenceChangeListener
{
	static
	{
		MonoBridge.link(Preference_OnPreferenceChangeListenerDelegateWrapper.class, "onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z", "android.preference.Preference,java.lang.Object");

	}

	@Override
	public native boolean onPreferenceChange(android.preference.Preference arg0,java.lang.Object arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
