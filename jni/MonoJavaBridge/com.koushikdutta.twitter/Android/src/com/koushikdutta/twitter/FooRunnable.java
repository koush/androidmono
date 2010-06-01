package com.koushikdutta.twitter;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class FooRunnable implements MonoProxy, java.lang.Runnable
{
	static
	{
		MonoBridge.link(FooRunnable.class, "run", "()V", "");

	}

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
