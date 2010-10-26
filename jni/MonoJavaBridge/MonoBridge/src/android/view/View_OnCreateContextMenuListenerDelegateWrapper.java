package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnCreateContextMenuListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.View.OnCreateContextMenuListener
{
	static
	{
		MonoBridge.link(View_OnCreateContextMenuListenerDelegateWrapper.class, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", "android.view.ContextMenu,android.view.View,android.view.ContextMenu_ContextMenuInfo");

	}

	@Override
	public native void onCreateContextMenu(android.view.ContextMenu arg0,android.view.View arg1,android.view.ContextMenu.ContextMenuInfo arg2);


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
