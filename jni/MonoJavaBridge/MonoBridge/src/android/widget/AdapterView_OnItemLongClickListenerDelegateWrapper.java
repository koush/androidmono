package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AdapterView_OnItemLongClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.AdapterView.OnItemLongClickListener
{
	static
	{
		MonoBridge.link(AdapterView_OnItemLongClickListenerDelegateWrapper.class, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z", "android.widget.AdapterView,android.view.View,System.Int32,System.Int64");

	}

	@Override
	public native boolean onItemLongClick(android.widget.AdapterView arg0,android.view.View arg1,int arg2,long arg3);


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
