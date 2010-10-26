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
