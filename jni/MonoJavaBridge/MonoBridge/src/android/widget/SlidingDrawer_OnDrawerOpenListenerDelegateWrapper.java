package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SlidingDrawer_OnDrawerOpenListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.SlidingDrawer.OnDrawerOpenListener
{
	static
	{
		MonoBridge.link(SlidingDrawer_OnDrawerOpenListenerDelegateWrapper.class, "onDrawerOpened", "()V", "");

	}

	@Override
	public native void onDrawerOpened();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
