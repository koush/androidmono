package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_OnZoomChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.hardware.Camera.OnZoomChangeListener
{
	static
	{
		MonoBridge.link(Camera_OnZoomChangeListenerDelegateWrapper.class, "onZoomChange", "(IZLandroid/hardware/Camera;)V", "System.Int32,System.Boolean,android.hardware.Camera");

	}

	@Override
	public native void onZoomChange(int arg0,boolean arg1,android.hardware.Camera arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
