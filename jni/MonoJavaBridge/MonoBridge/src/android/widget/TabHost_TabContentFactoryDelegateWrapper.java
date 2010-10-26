package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TabHost_TabContentFactoryDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.TabHost.TabContentFactory
{
	static
	{
		MonoBridge.link(TabHost_TabContentFactoryDelegateWrapper.class, "createTabContent", "(Ljava/lang/String;)Landroid/view/View;", "java.lang.String");

	}

	@Override
	public native android.view.View createTabContent(java.lang.String arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
