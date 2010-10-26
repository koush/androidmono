package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnGroupCollapseListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.ExpandableListView.OnGroupCollapseListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnGroupCollapseListenerDelegateWrapper.class, "onGroupCollapse", "(I)V", "System.Int32");

	}

	@Override
	public native void onGroupCollapse(int arg0);


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
