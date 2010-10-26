package android.view.inputmethod;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InputMethod_SessionCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.inputmethod.InputMethod.SessionCallback
{
	static
	{
		MonoBridge.link(InputMethod_SessionCallbackDelegateWrapper.class, "sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V", "android.view.inputmethod.InputMethodSession");

	}

	@Override
	public native void sessionCreated(android.view.inputmethod.InputMethodSession arg0);


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
