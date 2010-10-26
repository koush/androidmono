package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DatePickerDialog_OnDateSetListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.app.DatePickerDialog.OnDateSetListener
{
	static
	{
		MonoBridge.link(DatePickerDialog_OnDateSetListenerDelegateWrapper.class, "onDateSet", "(Landroid/widget/DatePicker;III)V", "android.widget.DatePicker,System.Int32,System.Int32,System.Int32");

	}

	@Override
	public native void onDateSet(android.widget.DatePicker arg0,int arg1,int arg2,int arg3);



}
