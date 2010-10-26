package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class IntentSender_OnFinishedDelegateWrapper extends java.lang.Object implements MonoProxy, android.content.IntentSender.OnFinished
{
	static
	{
		MonoBridge.link(IntentSender_OnFinishedDelegateWrapper.class, "onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V", "android.content.IntentSender,android.content.Intent,System.Int32,java.lang.String,android.os.Bundle");

	}

	@Override
	public native void onSendFinished(android.content.IntentSender arg0,android.content.Intent arg1,int arg2,java.lang.String arg3,android.os.Bundle arg4);


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
