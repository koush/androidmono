package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnShowListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.DialogInterface.OnShowListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnShowListenerDelegateWrapper.class, "onShow", "(Landroid/content/DialogInterface;)V", "android.content.DialogInterface");

	}

	@Override
	public native void onShow(android.content.DialogInterface arg0);


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
