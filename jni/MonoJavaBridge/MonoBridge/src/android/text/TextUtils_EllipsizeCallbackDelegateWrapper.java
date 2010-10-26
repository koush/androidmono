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
