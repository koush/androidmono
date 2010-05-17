namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface XMLReader 
	{ 
		void setProperty(java.lang.String arg0, java.lang.Object arg1); 
		java.lang.Object getProperty(java.lang.String arg0); 
		void parse(java.lang.String arg0); 
		void parse(org.xml.sax.InputSource arg0); 
		org.xml.sax.ContentHandler getContentHandler(); 
		void setFeature(java.lang.String arg0, bool arg1); 
		bool getFeature(java.lang.String arg0); 
		void setEntityResolver(org.xml.sax.EntityResolver arg0); 
		org.xml.sax.EntityResolver getEntityResolver(); 
		void setDTDHandler(org.xml.sax.DTDHandler arg0); 
		org.xml.sax.DTDHandler getDTDHandler(); 
		void setContentHandler(org.xml.sax.ContentHandler arg0); 
		void setErrorHandler(org.xml.sax.ErrorHandler arg0); 
		org.xml.sax.ErrorHandler getErrorHandler(); 
	} 
} 
