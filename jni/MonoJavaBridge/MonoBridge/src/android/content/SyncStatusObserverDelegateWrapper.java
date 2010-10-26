package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SyncStatusObserverDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.SyncStatusObserver
{
	static
	{
		MonoBridge.link(SyncStatusObserverDelegateWrapper.class, "onStatusChanged", "(I)V", "System.Int32");

	}

	@Override
	public native void onStatusChanged(int arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
