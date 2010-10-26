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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
