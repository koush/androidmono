package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RadioGroup_OnCheckedChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.RadioGroup.OnCheckedChangeListener
{
	static
	{
		MonoBridge.link(RadioGroup_OnCheckedChangeListenerDelegateWrapper.class, "onCheckedChanged", "(Landroid/widget/RadioGroup;I)V", "android.widget.RadioGroup,System.Int32");

	}

	@Override
	public native void onCheckedChanged(android.widget.RadioGroup arg0,int arg1);


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
