package android.location;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GpsStatus_ListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.location.GpsStatus.Listener
{
	static
	{
		MonoBridge.link(GpsStatus_ListenerDelegateWrapper.class, "onGpsStatusChanged", "(I)V", "System.Int32");

	}

	public native void onGpsStatusChanged(int arg0);



}
