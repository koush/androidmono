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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
