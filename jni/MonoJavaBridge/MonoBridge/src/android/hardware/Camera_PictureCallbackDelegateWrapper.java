package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_PictureCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.hardware.Camera.PictureCallback
{
	static
	{
		MonoBridge.link(Camera_PictureCallbackDelegateWrapper.class, "onPictureTaken", "([LSystem/Byte[];Landroid/hardware/Camera;)V", "System.Byte[],android.hardware.Camera");

	}

	@Override
	public native void onPictureTaken(byte[] arg0,android.hardware.Camera arg1);


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
