package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Html_ImageGetterDelegateWrapper extends java.lang.Object implements MonoProxy, android.text.Html.ImageGetter
{
	static
	{
		MonoBridge.link(Html_ImageGetterDelegateWrapper.class, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "java.lang.String");

	}

	@Override
	public native android.graphics.drawable.Drawable getDrawable(java.lang.String arg0);


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
