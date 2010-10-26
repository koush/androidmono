package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TimePickerDialog_OnTimeSetListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.app.TimePickerDialog.OnTimeSetListener
{
	static
	{
		MonoBridge.link(TimePickerDialog_OnTimeSetListenerDelegateWrapper.class, "onTimeSet", "(Landroid/widget/TimePicker;II)V", "android.widget.TimePicker,System.Int32,System.Int32");

	}

	@Override
	public native void onTimeSet(android.widget.TimePicker arg0,int arg1,int arg2);


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
