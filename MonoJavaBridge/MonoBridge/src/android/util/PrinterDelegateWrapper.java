package android.util;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PrinterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.util.Printer
{
	static
	{
		MonoBridge.link(PrinterDelegateWrapper.class, "println", "(Ljava/lang/String;)V", "java.lang.String");

	}

	@Override
	public native void println(java.lang.String arg0);



}
