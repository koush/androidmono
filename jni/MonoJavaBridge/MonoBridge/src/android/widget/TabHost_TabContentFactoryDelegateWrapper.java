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


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
