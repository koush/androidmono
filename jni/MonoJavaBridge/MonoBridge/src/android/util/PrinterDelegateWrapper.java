package android.util;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PrinterDelegateWrapper extends java.lang.Object implements MonoProxy, android.util.Printer
{
	static
	{
		MonoBridge.link(PrinterDelegateWrapper.class, "println", "(Ljava/lang/String;)V", "java.lang.String");

	}

	@Override
	public native void println(java.lang.String arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
