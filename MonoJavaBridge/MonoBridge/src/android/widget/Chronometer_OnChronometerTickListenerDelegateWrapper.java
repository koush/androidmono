package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Chronometer_OnChronometerTickListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.Chronometer.OnChronometerTickListener
{
	static
	{
		MonoBridge.link(Chronometer_OnChronometerTickListenerDelegateWrapper.class, "onChronometerTick", "(Landroid/widget/Chronometer;)V", "android.widget.Chronometer");

	}

	public native void onChronometerTick(android.widget.Chronometer arg0);



}
