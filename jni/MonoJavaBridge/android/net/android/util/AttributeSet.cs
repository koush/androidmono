namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AttributeSet 
	{ 
		java.lang.String getAttributeValue(int arg0); 
		java.lang.String getAttributeValue(java.lang.String arg0, java.lang.String arg1); 
		int getAttributeCount(); 
		java.lang.String getAttributeName(int arg0); 
		java.lang.String getPositionDescription(); 
		int getAttributeNameResource(int arg0); 
		int getAttributeListValue(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2, int arg3); 
		int getAttributeListValue(int arg0, java.lang.String[] arg1, int arg2); 
		bool getAttributeBooleanValue(java.lang.String arg0, java.lang.String arg1, bool arg2); 
		bool getAttributeBooleanValue(int arg0, bool arg1); 
		int getAttributeResourceValue(java.lang.String arg0, java.lang.String arg1, int arg2); 
		int getAttributeResourceValue(int arg0, int arg1); 
		int getAttributeIntValue(int arg0, int arg1); 
		int getAttributeIntValue(java.lang.String arg0, java.lang.String arg1, int arg2); 
		int getAttributeUnsignedIntValue(java.lang.String arg0, java.lang.String arg1, int arg2); 
		int getAttributeUnsignedIntValue(int arg0, int arg1); 
		float getAttributeFloatValue(java.lang.String arg0, java.lang.String arg1, float arg2); 
		float getAttributeFloatValue(int arg0, float arg1); 
		java.lang.String getIdAttribute(); 
		java.lang.String getClassAttribute(); 
		int getIdAttributeResourceValue(int arg0); 
		int getStyleAttribute(); 
	} 
} 
