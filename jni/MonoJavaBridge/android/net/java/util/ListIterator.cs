namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ListIterator : Iterator
	{ 
		void add(java.lang.Object arg0); 
		new bool hasNext(); 
		new java.lang.Object next(); 
		void set(java.lang.Object arg0); 
		new void remove(); 
		int previousIndex(); 
		bool hasPrevious(); 
		java.lang.Object previous(); 
		int nextIndex(); 
	} 
} 
