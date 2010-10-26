package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.DialogInterface.OnClickListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnClickListenerDelegateWrapper.class, "onClick", "(Landroid/content/DialogInterface;I)V", "android.content.DialogInterface,System.Int32");

	}

	@Override
	public native void onClick(android.content.DialogInterface arg0,int arg1);


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
