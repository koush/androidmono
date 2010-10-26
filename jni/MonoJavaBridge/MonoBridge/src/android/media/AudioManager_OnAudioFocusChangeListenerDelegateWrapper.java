package android.media;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class AudioManager_OnAudioFocusChangeListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.media.AudioManager.OnAudioFocusChangeListener
{
	static
	{
		MonoBridge.link(AudioManager_OnAudioFocusChangeListenerDelegateWrapper.class, "onAudioFocusChange", "(I)V", "System.Int32");

	}

	@Override
	public native void onAudioFocusChange(int arg0);



}
