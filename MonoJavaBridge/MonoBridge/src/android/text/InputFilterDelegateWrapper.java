package android.text;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class InputFilterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.text.InputFilter
{
	static
	{
		MonoBridge.link(InputFilterDelegateWrapper.class, "filter", "(Ljava/lang/CharSequence;IILandroid/text/Spanned;II)Ljava/lang/CharSequence;", "java.lang.CharSequence,System.Int32,System.Int32,android.text.Spanned,System.Int32,System.Int32");

	}

	@Override
	public native java.lang.CharSequence filter(java.lang.CharSequence arg0,int arg1,int arg2,android.text.Spanned arg3,int arg4,int arg5);



}
