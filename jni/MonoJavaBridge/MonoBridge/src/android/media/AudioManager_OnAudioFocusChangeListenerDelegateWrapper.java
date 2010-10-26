package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AudioManager_OnAudioFocusChangeListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.media.AudioManager.OnAudioFocusChangeListener
{
	static
	{
		MonoBridge.link(AudioManager_OnAudioFocusChangeListenerDelegateWrapper.class, "onAudioFocusChange", "(I)V", "System.Int32");

	}

	@Override
	public native void onAudioFocusChange(int arg0);


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
