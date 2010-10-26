package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Handler_CallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.os.Handler.Callback
{
	static
	{
		MonoBridge.link(Handler_CallbackDelegateWrapper.class, "handleMessage", "(Landroid/os/Message;)Z", "android.os.Message");

	}

	@Override
	public native boolean handleMessage(android.os.Message arg0);


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
