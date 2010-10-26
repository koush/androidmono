package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AdapterView_OnItemClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.AdapterView.OnItemClickListener
{
	static
	{
		MonoBridge.link(AdapterView_OnItemClickListenerDelegateWrapper.class, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "android.widget.AdapterView,android.view.View,System.Int32,System.Int64");

	}

	@Override
	public native void onItemClick(android.widget.AdapterView arg0,android.view.View arg1,int arg2,long arg3);


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
