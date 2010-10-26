package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnFocusChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.View.OnFocusChangeListener
{
	static
	{
		MonoBridge.link(View_OnFocusChangeListenerDelegateWrapper.class, "onFocusChange", "(Landroid/view/View;Z)V", "android.view.View,System.Boolean");

	}

	@Override
	public native void onFocusChange(android.view.View arg0,boolean arg1);


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
