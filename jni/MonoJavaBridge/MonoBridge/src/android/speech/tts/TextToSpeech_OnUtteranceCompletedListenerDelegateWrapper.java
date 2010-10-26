package android.speech.tts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextToSpeech_OnUtteranceCompletedListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.speech.tts.TextToSpeech.OnUtteranceCompletedListener
{
	static
	{
		MonoBridge.link(TextToSpeech_OnUtteranceCompletedListenerDelegateWrapper.class, "onUtteranceCompleted", "(Ljava/lang/String;)V", "java.lang.String");

	}

	@Override
	public native void onUtteranceCompleted(java.lang.String arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
