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
