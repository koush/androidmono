package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnBufferingUpdateListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaPlayer.OnBufferingUpdateListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnBufferingUpdateListenerDelegateWrapper.class, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", "android.media.MediaPlayer,System.Int32");

	}

	public native void onBufferingUpdate(android.media.MediaPlayer arg0,int arg1);



}
