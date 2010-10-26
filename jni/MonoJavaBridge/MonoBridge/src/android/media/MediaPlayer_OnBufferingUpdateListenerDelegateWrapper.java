package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnBufferingUpdateListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaPlayer.OnBufferingUpdateListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnBufferingUpdateListenerDelegateWrapper.class, "onBufferingUpdate", "(Landroid/media/MediaPlayer;I)V", "android.media.MediaPlayer,System.Int32");

	}

	@Override
	public native void onBufferingUpdate(android.media.MediaPlayer arg0,int arg1);


	long myGCHandle;
	public long getGCHandle() {
		return myGCHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGCHandle = gcHandle;
	}

	@Override
	protected void finalize() throws Throwable {
	    super.finalize();
	    MonoBridge.releaseGCHandle(myGCHandle);
	}
}
