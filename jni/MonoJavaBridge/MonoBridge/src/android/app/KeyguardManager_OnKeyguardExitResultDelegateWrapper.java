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
