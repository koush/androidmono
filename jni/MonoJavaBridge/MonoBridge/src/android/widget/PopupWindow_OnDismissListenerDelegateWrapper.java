package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PopupWindow_OnDismissListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.PopupWindow.OnDismissListener
{
	static
	{
		MonoBridge.link(PopupWindow_OnDismissListenerDelegateWrapper.class, "onDismiss", "()V", "");

	}

	@Override
	public native void onDismiss();


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
