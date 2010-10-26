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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
