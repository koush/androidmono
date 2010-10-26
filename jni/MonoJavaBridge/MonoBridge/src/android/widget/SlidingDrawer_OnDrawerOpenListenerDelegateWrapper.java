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
