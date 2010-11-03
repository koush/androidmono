package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnChildClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.ExpandableListView.OnChildClickListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnChildClickListenerDelegateWrapper.class, "onChildClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IIJ)Z", "android.widget.ExpandableListView,android.view.View,System.Int32,System.Int32,System.Int64");

	}

	public native boolean onChildClick(android.widget.ExpandableListView arg0,android.view.View arg1,int arg2,int arg3,long arg4);



}
