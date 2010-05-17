namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface AttributedCharacterIterator : CharacterIterator
	{ 
		java.util.Map getAttributes(); 
		java.lang.Object getAttribute(java.text.AttributedCharacterIterator_Attribute arg0); 
		int getRunStart(java.util.Set arg0); 
		int getRunStart(java.text.AttributedCharacterIterator_Attribute arg0); 
		int getRunStart(); 
		int getRunLimit(java.text.AttributedCharacterIterator_Attribute arg0); 
		int getRunLimit(); 
		int getRunLimit(java.util.Set arg0); 
		java.util.Set getAllAttributeKeys(); 
	} 
} 
