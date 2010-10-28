package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnShowListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.content.DialogInterface.OnShowListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnShowListenerDelegateWrapper.class, "onShow", "(Landroid/content/DialogInterface;)V", "android.content.DialogInterface");

	}

	@Override
	public native void onShow(android.content.DialogInterface arg0);



}
