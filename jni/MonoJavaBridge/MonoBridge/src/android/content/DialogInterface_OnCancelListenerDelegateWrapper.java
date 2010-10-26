package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnCancelListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.content.DialogInterface.OnCancelListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnCancelListenerDelegateWrapper.class, "onCancel", "(Landroid/content/DialogInterface;)V", "android.content.DialogInterface");

	}

	@Override
	public native void onCancel(android.content.DialogInterface arg0);



}
