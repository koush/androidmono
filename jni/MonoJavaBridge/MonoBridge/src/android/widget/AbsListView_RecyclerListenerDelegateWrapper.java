package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AbsListView_RecyclerListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.AbsListView.RecyclerListener
{
	static
	{
		MonoBridge.link(AbsListView_RecyclerListenerDelegateWrapper.class, "onMovedToScrapHeap", "(Landroid/view/View;)V", "android.view.View");

	}

	@Override
	public native void onMovedToScrapHeap(android.view.View arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
