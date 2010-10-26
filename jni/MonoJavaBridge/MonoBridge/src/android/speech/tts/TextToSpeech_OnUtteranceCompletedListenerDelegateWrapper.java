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
