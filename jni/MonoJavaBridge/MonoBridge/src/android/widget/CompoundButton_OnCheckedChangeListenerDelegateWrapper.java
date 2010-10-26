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
