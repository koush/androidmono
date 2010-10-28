package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WebIconDatabase_IconListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.webkit.WebIconDatabase.IconListener
{
	static
	{
		MonoBridge.link(WebIconDatabase_IconListenerDelegateWrapper.class, "onReceivedIcon", "(Ljava/lang/String;Landroid/graphics/Bitmap;)V", "java.lang.String,android.graphics.Bitmap");

	}

	@Override
	public native void onReceivedIcon(java.lang.String arg0,android.graphics.Bitmap arg1);



}
