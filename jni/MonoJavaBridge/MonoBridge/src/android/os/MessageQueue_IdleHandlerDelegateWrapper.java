package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MessageQueue_IdleHandlerDelegateWrapper extends java.lang.Object implements MonoProxy, android.os.MessageQueue.IdleHandler
{
	static
	{
		MonoBridge.link(MessageQueue_IdleHandlerDelegateWrapper.class, "queueIdle", "()Z", "");

	}

	@Override
	public native boolean queueIdle();


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
