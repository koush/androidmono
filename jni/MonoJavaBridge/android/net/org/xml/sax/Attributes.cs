namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Attributes 
	{ 
		int getLength(); 
		java.lang.String getValue(java.lang.String arg0); 
		java.lang.String getValue(int arg0); 
		java.lang.String getValue(java.lang.String arg0, java.lang.String arg1); 
		java.lang.String getType(int arg0); 
		java.lang.String getType(java.lang.String arg0, java.lang.String arg1); 
		java.lang.String getType(java.lang.String arg0); 
		int getIndex(java.lang.String arg0); 
		int getIndex(java.lang.String arg0, java.lang.String arg1); 
		java.lang.String getQName(int arg0); 
		java.lang.String getLocalName(int arg0); 
		java.lang.String getURI(int arg0); 
	} 
} 
