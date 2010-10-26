package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaRecorder_OnInfoListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.MediaRecorder.OnInfoListener
{
	static
	{
		MonoBridge.link(MediaRecorder_OnInfoListenerDelegateWrapper.class, "onInfo", "(Landroid/media/MediaRecorder;II)V", "android.media.MediaRecorder,System.Int32,System.Int32");

	}

	@Override
	public native void onInfo(android.media.MediaRecorder arg0,int arg1,int arg2);



}
