package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class TextUtils_EllipsizeCallbackDelegateWrapper extends java.lang.Object implements MonoProxy, android.text.TextUtils.EllipsizeCallback
{
	static
	{
		MonoBridge.link(TextUtils_EllipsizeCallbackDelegateWrapper.class, "ellipsized", "(II)V", "System.Int32,System.Int32");

	}

	@Override
	public native void ellipsized(int arg0,int arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
