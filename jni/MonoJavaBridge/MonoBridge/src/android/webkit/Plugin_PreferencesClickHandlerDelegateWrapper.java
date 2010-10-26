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
