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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
