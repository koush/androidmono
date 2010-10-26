package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WebChromeClient_CustomViewCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.WebChromeClient.CustomViewCallback
{
	static
	{
		MonoBridge.link(WebChromeClient_CustomViewCallbackDelegateWrapper.class, "onCustomViewHidden", "()V", "");

	}

	@Override
	public native void onCustomViewHidden();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
