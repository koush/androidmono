package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnPreparedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaPlayer.OnPreparedListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnPreparedListenerDelegateWrapper.class, "onPrepared", "(Landroid/media/MediaPlayer;)V", "android.media.MediaPlayer");

	}

	@Override
	public native void onPrepared(android.media.MediaPlayer arg0);


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
