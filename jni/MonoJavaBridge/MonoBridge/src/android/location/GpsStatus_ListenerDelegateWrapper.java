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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
