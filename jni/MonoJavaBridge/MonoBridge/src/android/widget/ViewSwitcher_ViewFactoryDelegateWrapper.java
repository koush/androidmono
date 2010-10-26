package android.widget;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class ViewSwitcher_ViewFactoryDelegateWrapper extends java.lang.Object implements MonoProxy, android.widget.ViewSwitcher.ViewFactory
{
	static
	{
		MonoBridge.link(ViewSwitcher_ViewFactoryDelegateWrapper.class, "makeView", "()Landroid/view/View;", "");

	}

	@Override
	public native android.view.View makeView();


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
