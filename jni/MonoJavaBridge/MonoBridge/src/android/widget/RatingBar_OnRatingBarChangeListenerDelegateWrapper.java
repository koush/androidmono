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
