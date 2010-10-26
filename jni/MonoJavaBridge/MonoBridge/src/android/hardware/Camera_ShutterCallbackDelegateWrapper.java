package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_ShutterCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.hardware.Camera.ShutterCallback
{
	static
	{
		MonoBridge.link(Camera_ShutterCallbackDelegateWrapper.class, "onShutter", "()V", "");

	}

	@Override
	public native void onShutter();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
