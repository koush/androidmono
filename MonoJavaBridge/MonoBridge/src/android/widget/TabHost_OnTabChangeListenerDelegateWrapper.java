package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TabHost_OnTabChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.TabHost.OnTabChangeListener
{
	static
	{
		MonoBridge.link(TabHost_OnTabChangeListenerDelegateWrapper.class, "onTabChanged", "(Ljava/lang/String;)V", "java.lang.String");

	}

	public native void onTabChanged(java.lang.String arg0);



}
