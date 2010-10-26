package android.location;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GpsStatus_ListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.location.GpsStatus.Listener
{
	static
	{
		MonoBridge.link(GpsStatus_ListenerDelegateWrapper.class, "onGpsStatusChanged", "(I)V", "System.Int32");

	}

	@Override
	public native void onGpsStatusChanged(int arg0);


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
