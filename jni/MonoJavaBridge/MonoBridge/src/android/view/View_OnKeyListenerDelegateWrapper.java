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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
