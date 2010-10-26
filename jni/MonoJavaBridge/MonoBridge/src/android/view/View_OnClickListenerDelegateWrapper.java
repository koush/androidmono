package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnClickListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.View.OnClickListener
{
	static
	{
		MonoBridge.link(View_OnClickListenerDelegateWrapper.class, "onClick", "(Landroid/view/View;)V", "android.view.View");

	}

	@Override
	public native void onClick(android.view.View arg0);


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
