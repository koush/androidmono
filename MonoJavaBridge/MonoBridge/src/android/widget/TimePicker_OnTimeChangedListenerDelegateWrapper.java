package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TimePicker_OnTimeChangedListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.widget.TimePicker.OnTimeChangedListener
{
	static
	{
		MonoBridge.link(TimePicker_OnTimeChangedListenerDelegateWrapper.class, "onTimeChanged", "(Landroid/widget/TimePicker;II)V", "android.widget.TimePicker,System.Int32,System.Int32");

	}

	public native void onTimeChanged(android.widget.TimePicker arg0,int arg1,int arg2);



}
