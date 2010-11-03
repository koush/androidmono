package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnSeekCompleteListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaPlayer.OnSeekCompleteListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnSeekCompleteListenerDelegateWrapper.class, "onSeekComplete", "(Landroid/media/MediaPlayer;)V", "android.media.MediaPlayer");

	}

	public native void onSeekComplete(android.media.MediaPlayer arg0);



}
