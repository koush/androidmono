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
