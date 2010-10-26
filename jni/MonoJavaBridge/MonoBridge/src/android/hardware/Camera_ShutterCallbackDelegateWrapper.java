package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_ShutterCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.hardware.Camera.ShutterCallback
{
	static
	{
		MonoBridge.link(Camera_ShutterCallbackDelegateWrapper.class, "onShutter", "()V", "");

	}

	@Override
	public native void onShutter();



}
