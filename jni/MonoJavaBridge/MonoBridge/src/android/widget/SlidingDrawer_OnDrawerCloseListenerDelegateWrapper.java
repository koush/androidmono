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
