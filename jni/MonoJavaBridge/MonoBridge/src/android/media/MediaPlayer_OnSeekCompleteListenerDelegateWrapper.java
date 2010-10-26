package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnSeekCompleteListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaPlayer.OnSeekCompleteListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnSeekCompleteListenerDelegateWrapper.class, "onSeekComplete", "(Landroid/media/MediaPlayer;)V", "android.media.MediaPlayer");

	}

	@Override
	public native void onSeekComplete(android.media.MediaPlayer arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
