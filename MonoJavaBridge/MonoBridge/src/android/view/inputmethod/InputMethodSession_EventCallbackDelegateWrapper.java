package android.view.inputmethod;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InputMethodSession_EventCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.inputmethod.InputMethodSession.EventCallback
{
	static
	{
		MonoBridge.link(InputMethodSession_EventCallbackDelegateWrapper.class, "finishedEvent", "(IZ)V", "System.Int32,System.Boolean");

	}

	@Override
	public native void finishedEvent(int arg0,boolean arg1);



}
