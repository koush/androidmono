package com.koushikdutta.twitter;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MainActivity extends android.app.Activity implements MonoProxy , java.lang.Runnable
{
	static
	{
		MonoBridge.link(MainActivity.class, "onCreate", "(Landroid/os/Bundle;)V", "android.os.Bundle");
		MonoBridge.link(MainActivity.class, "run", "()V", "");

	}

	@Override
	protected native void onCreate(android.os.Bundle arg0);
	@Override
	public native void run();


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
