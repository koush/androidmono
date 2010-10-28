package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaRecorder_OnErrorListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaRecorder.OnErrorListener
{
	static
	{
		MonoBridge.link(MediaRecorder_OnErrorListenerDelegateWrapper.class, "onError", "(Landroid/media/MediaRecorder;II)V", "android.media.MediaRecorder,System.Int32,System.Int32");

	}

	@Override
	public native void onError(android.media.MediaRecorder arg0,int arg1,int arg2);



}
