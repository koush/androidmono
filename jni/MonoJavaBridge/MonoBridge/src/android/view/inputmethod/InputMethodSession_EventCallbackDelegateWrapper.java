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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
