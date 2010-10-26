package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DatePickerDialog_OnDateSetListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.app.DatePickerDialog.OnDateSetListener
{
	static
	{
		MonoBridge.link(DatePickerDialog_OnDateSetListenerDelegateWrapper.class, "onDateSet", "(Landroid/widget/DatePicker;III)V", "android.widget.DatePicker,System.Int32,System.Int32,System.Int32");

	}

	@Override
	public native void onDateSet(android.widget.DatePicker arg0,int arg1,int arg2,int arg3);


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
