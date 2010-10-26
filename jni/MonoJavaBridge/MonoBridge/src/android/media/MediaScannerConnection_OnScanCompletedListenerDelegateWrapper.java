package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaScannerConnection_OnScanCompletedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaScannerConnection.OnScanCompletedListener
{
	static
	{
		MonoBridge.link(MediaScannerConnection_OnScanCompletedListenerDelegateWrapper.class, "onScanCompleted", "(Ljava/lang/String;Landroid/net/Uri;)V", "java.lang.String,android.net.Uri");

	}

	@Override
	public native void onScanCompleted(java.lang.String arg0,android.net.Uri arg1);


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
