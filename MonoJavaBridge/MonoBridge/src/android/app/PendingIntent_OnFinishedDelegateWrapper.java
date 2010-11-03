package android.app;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class PendingIntent_OnFinishedDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.app.PendingIntent.OnFinished
{
	static
	{
		MonoBridge.link(PendingIntent_OnFinishedDelegateWrapper.class, "onSendFinished", "(Landroid/app/PendingIntent;Landroid/content/Intent;ILjava/lang/String;Landroid/os/Bundle;)V", "android.app.PendingIntent,android.content.Intent,System.Int32,java.lang.String,android.os.Bundle");

	}

	public native void onSendFinished(android.app.PendingIntent arg0,android.content.Intent arg1,int arg2,java.lang.String arg3,android.os.Bundle arg4);



}
