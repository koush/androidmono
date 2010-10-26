package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class KeyguardManager_OnKeyguardExitResultDelegateWrapper extends java.lang.Object implements MonoProxy, android.app.KeyguardManager.OnKeyguardExitResult
{
	static
	{
		MonoBridge.link(KeyguardManager_OnKeyguardExitResultDelegateWrapper.class, "onKeyguardExitResult", "(Z)V", "System.Boolean");

	}

	@Override
	public native void onKeyguardExitResult(boolean arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
