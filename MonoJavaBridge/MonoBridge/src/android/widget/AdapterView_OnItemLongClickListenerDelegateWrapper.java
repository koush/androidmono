package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AdapterView_OnItemLongClickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.AdapterView.OnItemLongClickListener
{
	static
	{
		MonoBridge.link(AdapterView_OnItemLongClickListenerDelegateWrapper.class, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z", "android.widget.AdapterView,android.view.View,System.Int32,System.Int64");

	}

	public native boolean onItemLongClick(android.widget.AdapterView arg0,android.view.View arg1,int arg2,long arg3);



}
