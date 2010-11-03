package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Html_ImageGetterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.text.Html.ImageGetter
{
	static
	{
		MonoBridge.link(Html_ImageGetterDelegateWrapper.class, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "java.lang.String");

	}

	public native android.graphics.drawable.Drawable getDrawable(java.lang.String arg0);



}
