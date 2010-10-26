package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_PreviewCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.hardware.Camera.PreviewCallback
{
	static
	{
		MonoBridge.link(Camera_PreviewCallbackDelegateWrapper.class, "onPreviewFrame", "([LSystem/Byte[];Landroid/hardware/Camera;)V", "System.Byte[],android.hardware.Camera");

	}

	@Override
	public native void onPreviewFrame(byte[] arg0,android.hardware.Camera arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
