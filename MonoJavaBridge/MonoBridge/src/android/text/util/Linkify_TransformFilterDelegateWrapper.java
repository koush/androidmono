package android.text.util;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class Linkify_TransformFilterDelegateWrapper extends com.koushikdutta.monojavabridge.MonoProxyBase implements MonoProxy, android.text.util.Linkify.TransformFilter
{
	static
	{
		MonoBridge.link(Linkify_TransformFilterDelegateWrapper.class, "transformUrl", "(Ljava/util/regex/Matcher;Ljava/lang/String;)Ljava/lang/String;", "java.util.regex.Matcher,java.lang.String");

	}

	public native java.lang.String transformUrl(java.util.regex.Matcher arg0,java.lang.String arg1);



}
