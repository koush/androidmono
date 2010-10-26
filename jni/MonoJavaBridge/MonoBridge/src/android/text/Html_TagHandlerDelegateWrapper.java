package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Html_TagHandlerDelegateWrapper extends java.lang.Object implements MonoProxy, android.text.Html.TagHandler
{
	static
	{
		MonoBridge.link(Html_TagHandlerDelegateWrapper.class, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V", "System.Boolean,java.lang.String,android.text.Editable,org.xml.sax.XMLReader");

	}

	@Override
	public native void handleTag(boolean arg0,java.lang.String arg1,android.text.Editable arg2,org.xml.sax.XMLReader arg3);


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
