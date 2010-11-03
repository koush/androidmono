package internal.java.lang;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RunnableDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, java.lang.Runnable
{
	static
	{
		MonoBridge.link(RunnableDelegateWrapper.class, "run", "()V", "");

	}

	public native void run();



}
