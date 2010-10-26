package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnCompletionListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaPlayer.OnCompletionListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnCompletionListenerDelegateWrapper.class, "onCompletion", "(Landroid/media/MediaPlayer;)V", "android.media.MediaPlayer");

	}

	@Override
	public native void onCompletion(android.media.MediaPlayer arg0);


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
