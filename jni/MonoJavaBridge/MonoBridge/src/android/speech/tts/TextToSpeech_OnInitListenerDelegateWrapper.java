package android.speech.tts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextToSpeech_OnInitListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.speech.tts.TextToSpeech.OnInitListener
{
	static
	{
		MonoBridge.link(TextToSpeech_OnInitListenerDelegateWrapper.class, "onInit", "(I)V", "System.Int32");

	}

	@Override
	public native void onInit(int arg0);



}
