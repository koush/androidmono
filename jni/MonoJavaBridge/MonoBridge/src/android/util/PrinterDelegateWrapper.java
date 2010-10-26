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
