package android.view.inputmethod;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InputMethodSession_EventCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.inputmethod.InputMethodSession.EventCallback
{
	static
	{
		MonoBridge.link(InputMethodSession_EventCallbackDelegateWrapper.class, "finishedEvent", "(IZ)V", "System.Int32,System.Boolean");

	}

	@Override
	public native void finishedEvent(int arg0,boolean arg1);


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
