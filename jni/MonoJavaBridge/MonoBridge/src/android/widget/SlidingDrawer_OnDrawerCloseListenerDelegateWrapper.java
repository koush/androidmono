package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SlidingDrawer_OnDrawerCloseListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.SlidingDrawer.OnDrawerCloseListener
{
	static
	{
		MonoBridge.link(SlidingDrawer_OnDrawerCloseListenerDelegateWrapper.class, "onDrawerClosed", "()V", "");

	}

	@Override
	public native void onDrawerClosed();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
