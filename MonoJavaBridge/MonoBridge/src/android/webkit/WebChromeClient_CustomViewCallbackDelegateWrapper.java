package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WebChromeClient_CustomViewCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.webkit.WebChromeClient.CustomViewCallback
{
	static
	{
		MonoBridge.link(WebChromeClient_CustomViewCallbackDelegateWrapper.class, "onCustomViewHidden", "()V", "");

	}

	public native void onCustomViewHidden();



}
