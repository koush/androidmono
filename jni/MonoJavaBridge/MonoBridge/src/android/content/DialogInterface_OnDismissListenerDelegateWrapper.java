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
