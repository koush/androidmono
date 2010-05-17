namespace java.util 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SortedMap : Map
	{ 
		new java.util.Collection values(); 
		new java.util.Set entrySet(); 
		new java.util.Set keySet(); 
		java.util.Comparator comparator(); 
		java.util.SortedMap subMap(java.lang.Object arg0, java.lang.Object arg1); 
		java.util.SortedMap headMap(java.lang.Object arg0); 
		java.util.SortedMap tailMap(java.lang.Object arg0); 
		java.lang.Object firstKey(); 
		java.lang.Object lastKey(); 
	} 
} 
