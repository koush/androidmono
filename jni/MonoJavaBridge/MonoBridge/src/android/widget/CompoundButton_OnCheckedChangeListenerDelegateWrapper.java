package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class CompoundButton_OnCheckedChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.CompoundButton.OnCheckedChangeListener
{
	static
	{
		MonoBridge.link(CompoundButton_OnCheckedChangeListenerDelegateWrapper.class, "onCheckedChanged", "(Landroid/widget/CompoundButton;Z)V", "android.widget.CompoundButton,System.Boolean");

	}

	@Override
	public native void onCheckedChanged(android.widget.CompoundButton arg0,boolean arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
