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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
