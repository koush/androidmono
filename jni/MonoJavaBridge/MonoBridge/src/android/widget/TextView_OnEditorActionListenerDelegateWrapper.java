package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextView_OnEditorActionListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.TextView.OnEditorActionListener
{
	static
	{
		MonoBridge.link(TextView_OnEditorActionListenerDelegateWrapper.class, "onEditorAction", "(Landroid/widget/TextView;ILandroid/view/KeyEvent;)Z", "android.widget.TextView,System.Int32,android.view.KeyEvent");

	}

	@Override
	public native boolean onEditorAction(android.widget.TextView arg0,int arg1,android.view.KeyEvent arg2);



}
