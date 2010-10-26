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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
