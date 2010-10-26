package android.view;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class LayoutInflater_FactoryDelegateWrapper extends java.lang.Object implements MonoProxy, android.view.LayoutInflater.Factory
{
	static
	{
		MonoBridge.link(LayoutInflater_FactoryDelegateWrapper.class, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", "java.lang.String,android.content.Context,android.util.AttributeSet");

	}

	@Override
	public native android.view.View onCreateView(java.lang.String arg0,android.content.Context arg1,android.util.AttributeSet arg2);


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
