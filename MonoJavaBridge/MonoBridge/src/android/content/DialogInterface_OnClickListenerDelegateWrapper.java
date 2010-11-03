package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.content.DialogInterface.OnClickListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnClickListenerDelegateWrapper.class, "onClick", "(Landroid/content/DialogInterface;I)V", "android.content.DialogInterface,System.Int32");

	}

	public native void onClick(android.content.DialogInterface arg0,int arg1);



}
