namespace java.security.cert 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface X509Extension 
	{ 
		bool hasUnsupportedCriticalExtension(); 
		java.util.Set getCriticalExtensionOIDs(); 
		java.util.Set getNonCriticalExtensionOIDs(); 
		byte[] getExtensionValue(java.lang.String arg0); 
	} 
} 
