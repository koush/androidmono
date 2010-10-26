package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class DownloadListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.DownloadListener
{
	static
	{
		MonoBridge.link(DownloadListenerDelegateWrapper.class, "onDownloadStart", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;J)V", "java.lang.String,java.lang.String,java.lang.String,java.lang.String,System.Int64");

	}

	@Override
	public native void onDownloadStart(java.lang.String arg0,java.lang.String arg1,java.lang.String arg2,java.lang.String arg3,long arg4);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
