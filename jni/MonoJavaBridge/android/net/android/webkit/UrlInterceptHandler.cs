namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface UrlInterceptHandler 
	{ 
		android.webkit.CacheManager.CacheResult service(java.lang.String arg0, java.util.Map arg1); 
		android.webkit.PluginData getPluginData(java.lang.String arg0, java.util.Map arg1); 
	} 
} 
