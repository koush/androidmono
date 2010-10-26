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
