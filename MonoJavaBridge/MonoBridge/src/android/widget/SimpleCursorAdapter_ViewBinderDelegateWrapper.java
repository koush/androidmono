package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SimpleCursorAdapter_ViewBinderDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.SimpleCursorAdapter.ViewBinder
{
	static
	{
		MonoBridge.link(SimpleCursorAdapter_ViewBinderDelegateWrapper.class, "setViewValue", "(Landroid/view/View;Landroid/database/Cursor;I)Z", "android.view.View,android.database.Cursor,System.Int32");

	}

	public native boolean setViewValue(android.view.View arg0,android.database.Cursor arg1,int arg2);



}
