package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Preference_OnPreferenceChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.preference.Preference.OnPreferenceChangeListener
{
	static
	{
		MonoBridge.link(Preference_OnPreferenceChangeListenerDelegateWrapper.class, "onPreferenceChange", "(Landroid/preference/Preference;Ljava/lang/Object;)Z", "android.preference.Preference,java.lang.Object");

	}

	public native boolean onPreferenceChange(android.preference.Preference arg0,java.lang.Object arg1);



}
