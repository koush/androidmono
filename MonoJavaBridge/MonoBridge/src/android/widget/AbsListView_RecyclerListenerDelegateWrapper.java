package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AbsListView_RecyclerListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.AbsListView.RecyclerListener
{
	static
	{
		MonoBridge.link(AbsListView_RecyclerListenerDelegateWrapper.class, "onMovedToScrapHeap", "(Landroid/view/View;)V", "android.view.View");

	}

	public native void onMovedToScrapHeap(android.view.View arg0);



}
