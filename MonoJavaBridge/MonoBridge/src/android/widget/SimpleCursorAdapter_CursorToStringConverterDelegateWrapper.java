package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SimpleCursorAdapter_CursorToStringConverterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.SimpleCursorAdapter.CursorToStringConverter
{
	static
	{
		MonoBridge.link(SimpleCursorAdapter_CursorToStringConverterDelegateWrapper.class, "convertToString", "(Landroid/database/Cursor;)Ljava/lang/CharSequence;", "android.database.Cursor");

	}

	public native java.lang.CharSequence convertToString(android.database.Cursor arg0);



}
