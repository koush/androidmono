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
