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
