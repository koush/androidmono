package android.view.animation;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InterpolatorDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.animation.Interpolator
{
	static
	{
		MonoBridge.link(InterpolatorDelegateWrapper.class, "getInterpolation", "(F)F", "System.Single");

	}

	@Override
	public native float getInterpolation(float arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
