package com.koushikdutta.helloworld;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class HelloWorldActivity extends Activity implements MonoProxy, android.view.View.OnClickListener
{
	static
	{
		MonoBridge.link(HelloWorldActivity.class, "onCreate", "(Landroid/os/Bundle;)V", "android.os.Bundle");
		MonoBridge.link(HelloWorldActivity.class, "onClick", "(Landroid/view/View;)V", "android.view.View");
	}
	
	@Override
	protected native void onCreate(Bundle savedInstanceState);

	long myGcHandle;
	@Override
	public long getGCHandle() {
		return myGcHandle;
	}

	@Override
	public void setGCHandle(long gcHandle) {
		Log.i("Hello", "GC Handle set");
		myGcHandle = gcHandle;
	}

	@Override
	public native void onClick(View v);
}
