package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnGlobalLayoutListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.ViewTreeObserver.OnGlobalLayoutListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnGlobalLayoutListenerDelegateWrapper.class, "onGlobalLayout", "()V", "");

	}

	@Override
	public native void onGlobalLayout();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
