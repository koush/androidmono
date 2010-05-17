namespace java.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface CharacterIterator : java.lang.Cloneable
	{ 
		java.lang.Object clone(); 
		char next(); 
		char previous(); 
		int getIndex(); 
		char current(); 
		char setIndex(int arg0); 
		int getBeginIndex(); 
		int getEndIndex(); 
		char last(); 
		char first(); 
	} 
} 
