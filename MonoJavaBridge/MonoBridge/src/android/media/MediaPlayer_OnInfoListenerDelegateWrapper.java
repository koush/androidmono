package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnInfoListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaPlayer.OnInfoListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnInfoListenerDelegateWrapper.class, "onInfo", "(Landroid/media/MediaPlayer;II)Z", "android.media.MediaPlayer,System.Int32,System.Int32");

	}

	@Override
	public native boolean onInfo(android.media.MediaPlayer arg0,int arg1,int arg2);



}
