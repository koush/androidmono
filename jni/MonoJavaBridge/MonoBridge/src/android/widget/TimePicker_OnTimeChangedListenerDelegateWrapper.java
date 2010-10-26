package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TimePicker_OnTimeChangedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.TimePicker.OnTimeChangedListener
{
	static
	{
		MonoBridge.link(TimePicker_OnTimeChangedListenerDelegateWrapper.class, "onTimeChanged", "(Landroid/widget/TimePicker;II)V", "android.widget.TimePicker,System.Int32,System.Int32");

	}

	@Override
	public native void onTimeChanged(android.widget.TimePicker arg0,int arg1,int arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
