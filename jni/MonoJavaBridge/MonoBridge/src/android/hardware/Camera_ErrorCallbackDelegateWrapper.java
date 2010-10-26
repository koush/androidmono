package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_ErrorCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.hardware.Camera.ErrorCallback
{
	static
	{
		MonoBridge.link(Camera_ErrorCallbackDelegateWrapper.class, "onError", "(ILandroid/hardware/Camera;)V", "System.Int32,android.hardware.Camera");

	}

	@Override
	public native void onError(int arg0,android.hardware.Camera arg1);


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
