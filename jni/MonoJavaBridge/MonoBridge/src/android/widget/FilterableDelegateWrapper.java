package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class FilterableDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.Filterable
{
	static
	{
		MonoBridge.link(FilterableDelegateWrapper.class, "getFilter", "()Landroid/widget/Filter;", "");

	}

	@Override
	public native android.widget.Filter getFilter();


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
