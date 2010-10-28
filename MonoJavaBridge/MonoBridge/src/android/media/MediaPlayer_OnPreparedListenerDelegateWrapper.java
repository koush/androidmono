package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnPreparedListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaPlayer.OnPreparedListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnPreparedListenerDelegateWrapper.class, "onPrepared", "(Landroid/media/MediaPlayer;)V", "android.media.MediaPlayer");

	}

	@Override
	public native void onPrepared(android.media.MediaPlayer arg0);



}
