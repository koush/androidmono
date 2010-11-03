package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnErrorListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaPlayer.OnErrorListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnErrorListenerDelegateWrapper.class, "onError", "(Landroid/media/MediaPlayer;II)Z", "android.media.MediaPlayer,System.Int32,System.Int32");

	}

	public native boolean onError(android.media.MediaPlayer arg0,int arg1,int arg2);



}
