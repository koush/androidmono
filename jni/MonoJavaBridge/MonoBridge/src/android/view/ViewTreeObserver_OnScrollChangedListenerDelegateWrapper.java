package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnScrollChangedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.ViewTreeObserver.OnScrollChangedListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnScrollChangedListenerDelegateWrapper.class, "onScrollChanged", "()V", "");

	}

	@Override
	public native void onScrollChanged();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
