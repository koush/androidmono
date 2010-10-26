package android.speech.tts;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextToSpeech_OnInitListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.speech.tts.TextToSpeech.OnInitListener
{
	static
	{
		MonoBridge.link(TextToSpeech_OnInitListenerDelegateWrapper.class, "onInit", "(I)V", "System.Int32");

	}

	@Override
	public native void onInit(int arg0);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
