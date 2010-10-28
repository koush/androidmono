package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DialogInterface_OnKeyListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.content.DialogInterface.OnKeyListener
{
	static
	{
		MonoBridge.link(DialogInterface_OnKeyListenerDelegateWrapper.class, "onKey", "(Landroid/content/DialogInterface;ILandroid/view/KeyEvent;)Z", "android.content.DialogInterface,System.Int32,android.view.KeyEvent");

	}

	@Override
	public native boolean onKey(android.content.DialogInterface arg0,int arg1,android.view.KeyEvent arg2);



}
