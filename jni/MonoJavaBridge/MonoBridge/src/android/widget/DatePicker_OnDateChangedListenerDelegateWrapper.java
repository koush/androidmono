package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DatePicker_OnDateChangedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.DatePicker.OnDateChangedListener
{
	static
	{
		MonoBridge.link(DatePicker_OnDateChangedListenerDelegateWrapper.class, "onDateChanged", "(Landroid/widget/DatePicker;III)V", "android.widget.DatePicker,System.Int32,System.Int32,System.Int32");

	}

	@Override
	public native void onDateChanged(android.widget.DatePicker arg0,int arg1,int arg2,int arg3);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
