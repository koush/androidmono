package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class LayoutInflater_FilterDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.LayoutInflater.Filter
{
	static
	{
		MonoBridge.link(LayoutInflater_FilterDelegateWrapper.class, "onLoadClass", "(Ljava/lang/Class;)Z", "java.lang.Class");

	}

	@Override
	public native boolean onLoadClass(java.lang.Class arg0);


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
