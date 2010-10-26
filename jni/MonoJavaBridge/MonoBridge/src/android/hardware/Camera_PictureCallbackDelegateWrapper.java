package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_PictureCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.hardware.Camera.PictureCallback
{
	static
	{
		MonoBridge.link(Camera_PictureCallbackDelegateWrapper.class, "onPictureTaken", "([LSystem/Byte[];Landroid/hardware/Camera;)V", "System.Byte[],android.hardware.Camera");

	}

	@Override
	public native void onPictureTaken(byte[] arg0,android.hardware.Camera arg1);



}
