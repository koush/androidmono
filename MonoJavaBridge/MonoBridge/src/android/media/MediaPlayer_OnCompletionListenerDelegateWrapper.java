package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnCompletionListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaPlayer.OnCompletionListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnCompletionListenerDelegateWrapper.class, "onCompletion", "(Landroid/media/MediaPlayer;)V", "android.media.MediaPlayer");

	}

	public native void onCompletion(android.media.MediaPlayer arg0);



}
