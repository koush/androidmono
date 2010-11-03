package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RatingBar_OnRatingBarChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.RatingBar.OnRatingBarChangeListener
{
	static
	{
		MonoBridge.link(RatingBar_OnRatingBarChangeListenerDelegateWrapper.class, "onRatingChanged", "(Landroid/widget/RatingBar;FZ)V", "android.widget.RatingBar,System.Single,System.Boolean");

	}

	public native void onRatingChanged(android.widget.RatingBar arg0,float arg1,boolean arg2);



}
