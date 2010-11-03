package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class IInterfaceDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.os.IInterface
{
	static
	{
		MonoBridge.link(IInterfaceDelegateWrapper.class, "asBinder", "()Landroid/os/IBinder;", "");

	}

	public native android.os.IBinder asBinder();



}
