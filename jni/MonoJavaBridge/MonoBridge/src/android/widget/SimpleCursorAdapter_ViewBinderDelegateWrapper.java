package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SimpleCursorAdapter_ViewBinderDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.SimpleCursorAdapter.ViewBinder
{
	static
	{
		MonoBridge.link(SimpleCursorAdapter_ViewBinderDelegateWrapper.class, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", "android.view.View,android.database.Cursor,System.Int32");

	}

	@Override
	public native boolean setViewValue(android.view.View arg0,android.database.Cursor arg1,int arg2);


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
