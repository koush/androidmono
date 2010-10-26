package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnGroupClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.ExpandableListView.OnGroupClickListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnGroupClickListenerDelegateWrapper.class, "onGroupClick", "(Landroid/widget/ExpandableListView;Landroid/view/View;IJ)Z", "android.widget.ExpandableListView,android.view.View,System.Int32,System.Int64");

	}

	@Override
	public native boolean onGroupClick(android.widget.ExpandableListView arg0,android.view.View arg1,int arg2,long arg3);



}
