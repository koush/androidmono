package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Preference_OnPreferenceClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.preference.Preference.OnPreferenceClickListener
{
	static
	{
		MonoBridge.link(Preference_OnPreferenceClickListenerDelegateWrapper.class, "onPreferenceClick", "(Landroid/preference/Preference;)Z", "android.preference.Preference");

	}

	public native boolean onPreferenceClick(android.preference.Preference arg0);



}
