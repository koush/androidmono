package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnKeyListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.View.OnKeyListener
{
	static
	{
		MonoBridge.link(View_OnKeyListenerDelegateWrapper.class, "onKey", "(Landroid/view/View;ILandroid/view/KeyEvent;)Z", "android.view.View,System.Int32,android.view.KeyEvent");

	}

	@Override
	public native boolean onKey(android.view.View arg0,int arg1,android.view.KeyEvent arg2);


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
