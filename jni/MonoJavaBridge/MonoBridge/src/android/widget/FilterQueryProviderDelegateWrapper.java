package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class FilterQueryProviderDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.FilterQueryProvider
{
	static
	{
		MonoBridge.link(FilterQueryProviderDelegateWrapper.class, "runQuery", "(Ljava/lang/CharSequence;)Landroid/database/Cursor;", "java.lang.CharSequence");

	}

	@Override
	public native android.database.Cursor runQuery(java.lang.CharSequence arg0);


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
