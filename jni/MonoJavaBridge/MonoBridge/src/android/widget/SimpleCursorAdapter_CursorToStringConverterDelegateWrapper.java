package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SimpleCursorAdapter_CursorToStringConverterDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.SimpleCursorAdapter.CursorToStringConverter
{
	static
	{
		MonoBridge.link(SimpleCursorAdapter_CursorToStringConverterDelegateWrapper.class, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", "android.database.Cursor");

	}

	@Override
	public native java.lang.CharSequence convertToString(android.database.Cursor arg0);


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
