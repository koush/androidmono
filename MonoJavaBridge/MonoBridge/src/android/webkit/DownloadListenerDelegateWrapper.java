package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DownloadListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.webkit.DownloadListener
{
	static
	{
		MonoBridge.link(DownloadListenerDelegateWrapper.class, "onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "java.lang.String,java.lang.String,java.lang.String,java.lang.String,System.Int64");

	}

	public native void onDownloadStart(java.lang.String arg0,java.lang.String arg1,java.lang.String arg2,java.lang.String arg3,long arg4);



}
