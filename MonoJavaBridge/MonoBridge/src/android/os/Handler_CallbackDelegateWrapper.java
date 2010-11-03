package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Handler_CallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.os.Handler.Callback
{
	static
	{
		MonoBridge.link(Handler_CallbackDelegateWrapper.class, "handleMessage", "(Landroid/os/Message;)Z", "android.os.Message");

	}

	public native boolean handleMessage(android.os.Message arg0);



}
