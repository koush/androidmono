package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewStub_OnInflateListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.ViewStub.OnInflateListener
{
	static
	{
		MonoBridge.link(ViewStub_OnInflateListenerDelegateWrapper.class, "onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V", "android.view.ViewStub,android.view.View");

	}

	public native void onInflate(android.view.ViewStub arg0,android.view.View arg1);



}
