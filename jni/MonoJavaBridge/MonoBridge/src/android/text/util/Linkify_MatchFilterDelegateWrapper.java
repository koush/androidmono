package android.text.util;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Linkify_MatchFilterDelegateWrapper extends java.lang.Object implements MonoProxy, android.text.util.Linkify.MatchFilter
{
	static
	{
		MonoBridge.link(Linkify_MatchFilterDelegateWrapper.class, "acceptMatch", "(Ljava/lang/CharSequence;II)Z", "java.lang.CharSequence,System.Int32,System.Int32");

	}

	@Override
	public native boolean acceptMatch(java.lang.CharSequence arg0,int arg1,int arg2);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}
