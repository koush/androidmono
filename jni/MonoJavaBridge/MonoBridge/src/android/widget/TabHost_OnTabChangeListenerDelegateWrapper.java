package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TabHost_OnTabChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.TabHost.OnTabChangeListener
{
	static
	{
		MonoBridge.link(TabHost_OnTabChangeListenerDelegateWrapper.class, "onTabChanged", "(Ljava/lang/String;)V", "java.lang.String");

	}

	@Override
	public native void onTabChanged(java.lang.String arg0);


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
