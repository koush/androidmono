package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class KeyguardManager_OnKeyguardExitResultDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.app.KeyguardManager.OnKeyguardExitResult
{
	static
	{
		MonoBridge.link(KeyguardManager_OnKeyguardExitResultDelegateWrapper.class, "onKeyguardExitResult", "(Z)V", "System.Boolean");

	}

	@Override
	public native void onKeyguardExitResult(boolean arg0);



}
