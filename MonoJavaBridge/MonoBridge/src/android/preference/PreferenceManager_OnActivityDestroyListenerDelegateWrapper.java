package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PreferenceManager_OnActivityDestroyListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.preference.PreferenceManager.OnActivityDestroyListener
{
	static
	{
		MonoBridge.link(PreferenceManager_OnActivityDestroyListenerDelegateWrapper.class, "onActivityDestroy", "()V", "");

	}

	@Override
	public native void onActivityDestroy();



}
