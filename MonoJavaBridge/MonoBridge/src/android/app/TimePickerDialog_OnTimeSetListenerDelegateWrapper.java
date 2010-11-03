package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TimePickerDialog_OnTimeSetListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.app.TimePickerDialog.OnTimeSetListener
{
	static
	{
		MonoBridge.link(TimePickerDialog_OnTimeSetListenerDelegateWrapper.class, "onTimeSet", "(Landroid/widget/TimePicker;II)V", "android.widget.TimePicker,System.Int32,System.Int32");

	}

	public native void onTimeSet(android.widget.TimePicker arg0,int arg1,int arg2);



}
