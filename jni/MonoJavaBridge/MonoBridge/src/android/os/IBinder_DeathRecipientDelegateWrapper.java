package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class IBinder_DeathRecipientDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.os.IBinder.DeathRecipient
{
	static
	{
		MonoBridge.link(IBinder_DeathRecipientDelegateWrapper.class, "binderDied", "()V", "");

	}

	@Override
	public native void binderDied();



}
