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


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
