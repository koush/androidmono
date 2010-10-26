package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class MediaPlayer_OnVideoSizeChangedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.MediaPlayer.OnVideoSizeChangedListener
{
	static
	{
		MonoBridge.link(MediaPlayer_OnVideoSizeChangedListenerDelegateWrapper.class, "onVideoSizeChanged", "(Landroid/media/MediaPlayer;II)V", "android.media.MediaPlayer,System.Int32,System.Int32");

	}

	@Override
	public native void onVideoSizeChanged(android.media.MediaPlayer arg0,int arg1,int arg2);


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
