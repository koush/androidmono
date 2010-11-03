package android.os;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class RecoverySystem_ProgressListenerDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.os.RecoverySystem.ProgressListener
{
	static
	{
		MonoBridge.link(RecoverySystem_ProgressListenerDelegateWrapper.class, "onProgress", "(I)V", "System.Int32");

	}

	public native void onProgress(int arg0);



}
