package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnDismissListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.DialogInterface.OnDismissListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnDismissListenerDelegateWrapper.class, "onDismiss", "(Landroid/content/DialogInterface;)V", "android.content.DialogInterface");

	}

	@Override
	public native void onDismiss(android.content.DialogInterface arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
