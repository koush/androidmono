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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
