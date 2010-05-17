namespace org.xmlpull.v1 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface XmlPullParser 
	{ 
		void setProperty(java.lang.String arg0, java.lang.Object arg1); 
		java.lang.Object getProperty(java.lang.String arg0); 
		java.lang.String getName(); 
		int next(); 
		int getLineNumber(); 
		bool isWhitespace(); 
		int nextToken(); 
		void setInput(java.io.InputStream arg0, java.lang.String arg1); 
		void setInput(java.io.Reader arg0); 
		java.lang.String getPrefix(); 
		java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1); 
		java.lang.String getAttributeValue(int arg0); 
		int getColumnNumber(); 
		java.lang.String getText(); 
		int getEventType(); 
		int getAttributeCount(); 
		java.lang.String getAttributeName(int arg0); 
		java.lang.String getPositionDescription(); 
		void setFeature(java.lang.String arg0, bool arg1); 
		bool getFeature(java.lang.String arg0); 
		java.lang.String getInputEncoding(); 
		void defineEntityReplacementText(java.lang.String arg0, java.lang.String arg1); 
		int getNamespaceCount(int arg0); 
		java.lang.String getNamespacePrefix(int arg0); 
		java.lang.String getNamespaceUri(int arg0); 
		java.lang.String getNamespace(); 
		java.lang.String getNamespace(java.lang.String arg0); 
		int getDepth(); 
		char[] getTextCharacters(int[] arg0); 
		bool isEmptyElementTag(); 
		java.lang.String getAttributeNamespace(int arg0); 
		java.lang.String getAttributePrefix(int arg0); 
		java.lang.String getAttributeType(int arg0); 
		bool isAttributeDefault(int arg0); 
		void require(int arg0, java.lang.String arg1, java.lang.String arg2); 
		java.lang.String nextText(); 
		int nextTag(); 
	} 
} 
