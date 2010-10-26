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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
