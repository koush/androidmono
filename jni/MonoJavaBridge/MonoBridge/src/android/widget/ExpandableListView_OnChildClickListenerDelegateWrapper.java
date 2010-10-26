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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
