package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnCancelListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.DialogInterface.OnCancelListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnCancelListenerDelegateWrapper.class, "onCancel", "(Landroid/content/DialogInterface;)V", "android.content.DialogInterface");

	}

	@Override
	public native void onCancel(android.content.DialogInterface arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
