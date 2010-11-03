package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextUtils_EllipsizeCallbackDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.text.TextUtils.EllipsizeCallback
{
	static
	{
		MonoBridge.link(TextUtils_EllipsizeCallbackDelegateWrapper.class, "ellipsized", "(II)V", "System.Int32,System.Int32");

	}

	public native void ellipsized(int arg0,int arg1);



}
