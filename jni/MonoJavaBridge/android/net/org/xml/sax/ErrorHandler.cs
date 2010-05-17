namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ErrorHandler 
	{ 
		void fatalError(org.xml.sax.SAXParseException arg0); 
		void error(org.xml.sax.SAXParseException arg0); 
		void warning(org.xml.sax.SAXParseException arg0); 
	} 
} 
