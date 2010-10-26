package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewTreeObserver_OnGlobalFocusChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.ViewTreeObserver.OnGlobalFocusChangeListener
{
	static
	{
		MonoBridge.link(ViewTreeObserver_OnGlobalFocusChangeListenerDelegateWrapper.class, "onGlobalFocusChanged", "(Landroid/view/View;Landroid/view/View;)V", "android.view.View,android.view.View");

	}

	@Override
	public native void onGlobalFocusChanged(android.view.View arg0,android.view.View arg1);


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
