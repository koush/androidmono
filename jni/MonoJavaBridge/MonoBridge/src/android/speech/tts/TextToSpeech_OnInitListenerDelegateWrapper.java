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
