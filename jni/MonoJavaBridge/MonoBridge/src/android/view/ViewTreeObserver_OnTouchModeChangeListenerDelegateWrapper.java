package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnTouchModeChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.ViewTreeObserver.OnTouchModeChangeListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnTouchModeChangeListenerDelegateWrapper.class, "onTouchModeChanged", "(Z)V", "System.Boolean");

	}

	@Override
	public native void onTouchModeChanged(boolean arg0);


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
