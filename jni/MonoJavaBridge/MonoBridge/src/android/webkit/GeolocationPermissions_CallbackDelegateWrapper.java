package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class GeolocationPermissions_CallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.GeolocationPermissions.Callback
{
	static
	{
		MonoBridge.link(GeolocationPermissions_CallbackDelegateWrapper.class, "invoke", "(Ljava/lang/String;ZZ)V", "java.lang.String,System.Boolean,System.Boolean");

	}

	@Override
	public native void invoke(java.lang.String arg0,boolean arg1,boolean arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
