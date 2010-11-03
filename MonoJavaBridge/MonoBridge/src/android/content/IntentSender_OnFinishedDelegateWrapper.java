package android.content;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class IntentSender_OnFinishedDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.content.IntentSender.OnFinished
{
	static
	{
		MonoBridge.link(IntentSender_OnFinishedDelegateWrapper.class, "onSendFinished", "(Landroid/content/IntentSender;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V", "android.content.IntentSender,android.content.Intent,System.Int32,java.lang.String,android.os.Bundle");

	}

	public native void onSendFinished(android.content.IntentSender arg0,android.content.Intent arg1,int arg2,java.lang.String arg3,android.os.Bundle arg4);



}
