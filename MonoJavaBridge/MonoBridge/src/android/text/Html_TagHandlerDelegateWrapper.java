package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Html_TagHandlerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.text.Html.TagHandler
{
	static
	{
		MonoBridge.link(Html_TagHandlerDelegateWrapper.class, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", "System.Boolean,java.lang.String,android.text.Editable,org.xml.sax.XMLReader");

	}

	public native void handleTag(boolean arg0,java.lang.String arg1,android.text.Editable arg2,org.xml.sax.XMLReader arg3);



}
