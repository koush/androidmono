package com.koushikdutta.monojavabridge.android;

import android.view.View;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class OnLongClickListener implements android.view.View.OnLongClickListener, MonoProxy {
	static
	{
		MonoBridge.link(OnLongClickListener.class, "onLongClick", "(Landroid/view/View;)Z", "android.view.View");
	}
	
	@Override
	public native boolean onLongClick(View v);

	long myGcHandle;
	@Override
	public long getGCHandle() {
		return myGcHandle;
	}

	@Override
	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
