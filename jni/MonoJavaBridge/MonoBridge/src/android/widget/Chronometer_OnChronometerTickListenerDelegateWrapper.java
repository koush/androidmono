package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Chronometer_OnChronometerTickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.Chronometer.OnChronometerTickListener
{
	static
	{
		MonoBridge.link(Chronometer_OnChronometerTickListenerDelegateWrapper.class, "onChronometerTick", "(Landroid/widget/Chronometer;)V", "android.widget.Chronometer");

	}

	@Override
	public native void onChronometerTick(android.widget.Chronometer arg0);


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
