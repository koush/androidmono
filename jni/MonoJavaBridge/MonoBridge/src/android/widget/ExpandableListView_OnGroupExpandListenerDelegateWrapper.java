package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnGroupExpandListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.ExpandableListView.OnGroupExpandListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnGroupExpandListenerDelegateWrapper.class, "onGroupExpand", "(I)V", "System.Int32");

	}

	@Override
	public native void onGroupExpand(int arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
