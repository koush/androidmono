package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RatingBar_OnRatingBarChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.RatingBar.OnRatingBarChangeListener
{
	static
	{
		MonoBridge.link(RatingBar_OnRatingBarChangeListenerDelegateWrapper.class, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V", "android.widget.RatingBar,System.Single,System.Boolean");

	}

	@Override
	public native void onRatingChanged(android.widget.RatingBar arg0,float arg1,boolean arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
