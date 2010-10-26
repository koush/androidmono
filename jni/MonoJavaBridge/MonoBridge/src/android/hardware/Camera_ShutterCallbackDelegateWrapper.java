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
