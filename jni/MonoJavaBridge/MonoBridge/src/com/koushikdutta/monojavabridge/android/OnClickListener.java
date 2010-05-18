package com.koushikdutta.monojavabridge.android;

import android.util.Log;
import android.view.View;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class OnClickListener implements android.view.View.OnClickListener, MonoProxy {
	static
	{
		MonoBridge.link(OnClickListener.class, "onClick", "(Landroid/view/View;)V", "android.view.View");
	}
	
	@Override
	public native void onClick(View v);

	long myGcHandle;
	@Override
	public long getGCHandle() {
		return myGcHandle;
	}

	@Override
	public void setGCHandle(long gcHandle) {
		Log.i("OnClickListener", "setGCHandle");
		myGcHandle = gcHandle;
	}
}
