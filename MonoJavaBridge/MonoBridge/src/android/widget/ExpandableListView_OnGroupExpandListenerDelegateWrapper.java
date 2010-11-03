package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ExpandableListView_OnGroupExpandListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.ExpandableListView.OnGroupExpandListener
{
	static
	{
		MonoBridge.link(ExpandableListView_OnGroupExpandListenerDelegateWrapper.class, "onGroupExpand", "(I)V", "System.Int32");

	}

	public native void onGroupExpand(int arg0);



}
