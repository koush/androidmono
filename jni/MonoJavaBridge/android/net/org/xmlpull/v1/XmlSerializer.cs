namespace org.xmlpull.v1 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface XmlSerializer 
	{ 
		void setProperty(java.lang.String arg0, java.lang.Object arg1); 
		java.lang.Object getProperty(java.lang.String arg0); 
		java.lang.String getName(); 
		void flush(); 
		void comment(java.lang.String arg0); 
		java.lang.String getPrefix(java.lang.String arg0, bool arg1); 
		org.xmlpull.v1.XmlSerializer text(char[] arg0, int arg1, int arg2); 
		org.xmlpull.v1.XmlSerializer text(java.lang.String arg0); 
		void startDocument(java.lang.String arg0, java.lang.Boolean arg1); 
		void endDocument(); 
		void ignorableWhitespace(java.lang.String arg0); 
		void processingInstruction(java.lang.String arg0); 
		void setFeature(java.lang.String arg0, bool arg1); 
		bool getFeature(java.lang.String arg0); 
		java.lang.String getNamespace(); 
		int getDepth(); 
		void setOutput(java.io.OutputStream arg0, java.lang.String arg1); 
		void setOutput(java.io.Writer arg0); 
		void setPrefix(java.lang.String arg0, java.lang.String arg1); 
		org.xmlpull.v1.XmlSerializer startTag(java.lang.String arg0, java.lang.String arg1); 
		org.xmlpull.v1.XmlSerializer attribute(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2); 
		org.xmlpull.v1.XmlSerializer endTag(java.lang.String arg0, java.lang.String arg1); 
		void cdsect(java.lang.String arg0); 
		void entityRef(java.lang.String arg0); 
		void docdecl(java.lang.String arg0); 
	} 
} 
