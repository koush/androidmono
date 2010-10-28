package android.view.inputmethod;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InputMethod_SessionCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.inputmethod.InputMethod.SessionCallback
{
	static
	{
		MonoBridge.link(InputMethod_SessionCallbackDelegateWrapper.class, "sessionCreated", "(Landroid/view/inputmethod/InputMethodSession;)V", "android.view.inputmethod.InputMethodSession");

	}

	@Override
	public native void sessionCreated(android.view.inputmethod.InputMethodSession arg0);



}
