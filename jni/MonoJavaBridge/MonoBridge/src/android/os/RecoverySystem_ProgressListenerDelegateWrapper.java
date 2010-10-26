package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RecoverySystem_ProgressListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.os.RecoverySystem.ProgressListener
{
	static
	{
		MonoBridge.link(RecoverySystem_ProgressListenerDelegateWrapper.class, "onProgress", "(I)V", "System.Int32");

	}

	@Override
	public native void onProgress(int arg0);


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
