package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Plugin_PreferencesClickHandlerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.webkit.Plugin.PreferencesClickHandler
{
	static
	{
		MonoBridge.link(Plugin_PreferencesClickHandlerDelegateWrapper.class, "handleClickEvent", "(Landroid/content/Context;)V", "android.content.Context");

	}

	@Override
	public native void handleClickEvent(android.content.Context arg0);



}
