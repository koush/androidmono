package android.view.animation;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InterpolatorDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.animation.Interpolator
{
	static
	{
		MonoBridge.link(InterpolatorDelegateWrapper.class, "getInterpolation", "(F)F", "System.Single");

	}

	public native float getInterpolation(float arg0);



}
