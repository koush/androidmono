package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnPreDrawListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.ViewTreeObserver.OnPreDrawListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnPreDrawListenerDelegateWrapper.class, "onPreDraw", "()Z", "");

	}

	@Override
	public native boolean onPreDraw();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
