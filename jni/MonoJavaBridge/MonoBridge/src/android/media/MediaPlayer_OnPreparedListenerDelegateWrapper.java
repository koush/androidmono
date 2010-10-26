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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
