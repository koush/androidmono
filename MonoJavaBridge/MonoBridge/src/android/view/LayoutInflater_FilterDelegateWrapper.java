package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class LayoutInflater_FilterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.view.LayoutInflater.Filter
{
	static
	{
		MonoBridge.link(LayoutInflater_FilterDelegateWrapper.class, "onLoadClass", "(Ljava/lang/Class;)Z", "java.lang.Class");

	}

	public native boolean onLoadClass(java.lang.Class arg0);



}
