package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class IInterfaceDelegateWrapper extends java.lang.Object implements MonoProxy, android.os.IInterface
{
	static
	{
		MonoBridge.link(IInterfaceDelegateWrapper.class, "asBinder", "()Landroid/os/IBinder;", "");

	}

	@Override
	public native android.os.IBinder asBinder();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
