package android.hardware;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Camera_AutoFocusCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.hardware.Camera.AutoFocusCallback
{
	static
	{
		MonoBridge.link(Camera_AutoFocusCallbackDelegateWrapper.class, "onAutoFocus", "(ZLandroid/hardware/Camera;)V", "System.Boolean,android.hardware.Camera");

	}

	public native void onAutoFocus(boolean arg0,android.hardware.Camera arg1);



}
