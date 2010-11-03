package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PopupWindow_OnDismissListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.PopupWindow.OnDismissListener
{
	static
	{
		MonoBridge.link(PopupWindow_OnDismissListenerDelegateWrapper.class, "onDismiss", "()V", "");

	}

	public native void onDismiss();



}
