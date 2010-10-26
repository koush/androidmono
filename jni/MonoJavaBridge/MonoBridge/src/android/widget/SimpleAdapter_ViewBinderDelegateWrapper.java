package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SimpleAdapter_ViewBinderDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.SimpleAdapter.ViewBinder
{
	static
	{
		MonoBridge.link(SimpleAdapter_ViewBinderDelegateWrapper.class, "setViewValue", "(Landroid/view/View;Ljava/lang/Object;Ljava/lang/String;)Z", "android.view.View,java.lang.Object,java.lang.String");

	}

	@Override
	public native boolean setViewValue(android.view.View arg0,java.lang.Object arg1,java.lang.String arg2);


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
