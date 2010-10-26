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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
