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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
