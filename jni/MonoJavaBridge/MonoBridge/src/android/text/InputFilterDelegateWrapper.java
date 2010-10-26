package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InputFilterDelegateWrapper extends java.lang.Object implements MonoProxy, android.text.InputFilter
{
	static
	{
		MonoBridge.link(InputFilterDelegateWrapper.class, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", "java.lang.CharSequence,System.Int32,System.Int32,android.text.Spanned,System.Int32,System.Int32");

	}

	@Override
	public native java.lang.CharSequence filter(java.lang.CharSequence arg0,int arg1,int arg2,android.text.Spanned arg3,int arg4,int arg5);


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
