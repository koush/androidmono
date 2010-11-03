package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TabHost_TabContentFactoryDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.TabHost.TabContentFactory
{
	static
	{
		MonoBridge.link(TabHost_TabContentFactoryDelegateWrapper.class, "createTabContent", "(Ljava/lang/String;)Landroid/view/View;", "java.lang.String");

	}

	public native android.view.View createTabContent(java.lang.String arg0);



}
