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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
