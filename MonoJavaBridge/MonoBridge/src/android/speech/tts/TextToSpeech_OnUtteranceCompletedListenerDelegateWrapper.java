package android.speech.tts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextToSpeech_OnUtteranceCompletedListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.speech.tts.TextToSpeech.OnUtteranceCompletedListener
{
	static
	{
		MonoBridge.link(TextToSpeech_OnUtteranceCompletedListenerDelegateWrapper.class, "onUtteranceCompleted", "(Ljava/lang/String;)V", "java.lang.String");

	}

	public native void onUtteranceCompleted(java.lang.String arg0);



}
