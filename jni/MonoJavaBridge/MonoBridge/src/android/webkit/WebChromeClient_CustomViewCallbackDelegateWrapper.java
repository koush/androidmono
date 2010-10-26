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
