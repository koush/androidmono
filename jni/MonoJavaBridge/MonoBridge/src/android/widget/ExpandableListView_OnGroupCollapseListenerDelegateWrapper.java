package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnGroupCollapseListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.ExpandableListView.OnGroupCollapseListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnGroupCollapseListenerDelegateWrapper.class, "onGroupCollapse", "(I)V", "System.Int32");

	}

	@Override
	public native void onGroupCollapse(int arg0);



}
