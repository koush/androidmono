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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
