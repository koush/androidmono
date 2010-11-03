package android.preference;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PreferenceManager_OnActivityResultListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.preference.PreferenceManager.OnActivityResultListener
{
	static
	{
		MonoBridge.link(PreferenceManager_OnActivityResultListenerDelegateWrapper.class, "onActivityResult", "(IILandroid/content/Intent;)Z", "System.Int32,System.Int32,android.content.Intent");

	}

	public native boolean onActivityResult(int arg0,int arg1,android.content.Intent arg2);



}
