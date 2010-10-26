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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
