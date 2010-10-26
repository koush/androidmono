package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnTouchListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.View.OnTouchListener
{
	static
	{
		MonoBridge.link(View_OnTouchListenerDelegateWrapper.class, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "android.view.View,android.view.MotionEvent");

	}

	@Override
	public native boolean onTouch(android.view.View arg0,android.view.MotionEvent arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
