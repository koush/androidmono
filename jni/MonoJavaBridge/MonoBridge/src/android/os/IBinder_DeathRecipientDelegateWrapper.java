package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class IBinder_DeathRecipientDelegateWrapper extends java.lang.Object implements MonoProxy, android.os.IBinder.DeathRecipient
{
	static
	{
		MonoBridge.link(IBinder_DeathRecipientDelegateWrapper.class, "binderDied", "()V", "");

	}

	@Override
	public native void binderDied();


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
