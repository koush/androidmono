namespace org.xml.sax 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ContentHandler 
	{ 
		void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3); 
		void characters(char[] arg0, int arg1, int arg2); 
		void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2); 
		void startDocument(); 
		void endDocument(); 
		void startPrefixMapping(java.lang.String arg0, java.lang.String arg1); 
		void ignorableWhitespace(char[] arg0, int arg1, int arg2); 
		void processingInstruction(java.lang.String arg0, java.lang.String arg1); 
		void setDocumentLocator(org.xml.sax.Locator arg0); 
		void skippedEntity(java.lang.String arg0); 
		void endPrefixMapping(java.lang.String arg0); 
	} 
} 
