package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Filter_FilterListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.Filter.FilterListener
{
	static
	{
		MonoBridge.link(Filter_FilterListenerDelegateWrapper.class, "onFilterComplete", "(I)V", "System.Int32");

	}

	@Override
	public native void onFilterComplete(int arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
