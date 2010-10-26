package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Plugin_PreferencesClickHandlerDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.Plugin.PreferencesClickHandler
{
	static
	{
		MonoBridge.link(Plugin_PreferencesClickHandlerDelegateWrapper.class, "handleClickEvent", "(Landroid/content/Context;)V", "android.content.Context");

	}

	@Override
	public native void handleClickEvent(android.content.Context arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
