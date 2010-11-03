package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class SoundPool_OnLoadCompleteListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.SoundPool.OnLoadCompleteListener
{
	static
	{
		MonoBridge.link(SoundPool_OnLoadCompleteListenerDelegateWrapper.class, "onLoadComplete", "(Landroid/media/SoundPool;II)V", "android.media.SoundPool,System.Int32,System.Int32");

	}

	public native void onLoadComplete(android.media.SoundPool arg0,int arg1,int arg2);



}
