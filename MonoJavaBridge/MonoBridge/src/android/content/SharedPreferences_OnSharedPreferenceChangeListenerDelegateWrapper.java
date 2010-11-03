package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.content.SharedPreferences.OnSharedPreferenceChangeListener
{
	static
	{
		MonoBridge.link(SharedPreferences_OnSharedPreferenceChangeListenerDelegateWrapper.class, "onSharedPreferenceChanged", "(Landroid/content/SharedPreferences;Ljava/lang/String;)V", "android.content.SharedPreferences,java.lang.String");

	}

	public native void onSharedPreferenceChanged(android.content.SharedPreferences arg0,java.lang.String arg1);



}
