namespace java.security 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Key : java.io.Serializable
	{ 
		java.lang.String getAlgorithm(); 
		byte[] getEncoded(); 
		java.lang.String getFormat(); 
	} 
} 
