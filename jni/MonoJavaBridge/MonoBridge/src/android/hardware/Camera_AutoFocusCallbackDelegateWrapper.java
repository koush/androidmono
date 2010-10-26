package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_AutoFocusCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.hardware.Camera.AutoFocusCallback
{
	static
	{
		MonoBridge.link(Camera_AutoFocusCallbackDelegateWrapper.class, "onAutoFocus", "(ZLandroid/hardware/Camera;)V", "System.Boolean,android.hardware.Camera");

	}

	@Override
	public native void onAutoFocus(boolean arg0,android.hardware.Camera arg1);


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
