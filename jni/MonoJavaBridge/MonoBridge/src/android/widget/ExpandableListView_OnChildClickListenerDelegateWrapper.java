package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnChildClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.ExpandableListView.OnChildClickListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnChildClickListenerDelegateWrapper.class, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", "android.widget.ExpandableListView,android.view.View,System.Int32,System.Int32,System.Int64");

	}

	@Override
	public native boolean onChildClick(android.widget.ExpandableListView arg0,android.view.View arg1,int arg2,int arg3,long arg4);


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
