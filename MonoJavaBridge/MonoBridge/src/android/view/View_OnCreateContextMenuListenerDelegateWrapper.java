package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class View_OnCreateContextMenuListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.View.OnCreateContextMenuListener
{
	static
	{
		MonoBridge.link(View_OnCreateContextMenuListenerDelegateWrapper.class, "onCreateContextMenu", "(Landroid/view/ContextMenu;Landroid/view/View;Landroid/view/ContextMenu$ContextMenuInfo;)V", "android.view.ContextMenu,android.view.View,android.view.ContextMenu_ContextMenuInfo");

	}

	public native void onCreateContextMenu(android.view.ContextMenu arg0,android.view.View arg1,android.view.ContextMenu.ContextMenuInfo arg2);



}
