package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MessageQueue_IdleHandlerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.os.MessageQueue.IdleHandler
{
	static
	{
		MonoBridge.link(MessageQueue_IdleHandlerDelegateWrapper.class, "queueIdle", "()Z", "");

	}

	public native boolean queueIdle();



}
