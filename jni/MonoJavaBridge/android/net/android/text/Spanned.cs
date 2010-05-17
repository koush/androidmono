namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Spanned : java.lang.CharSequence
	{ 
		java.lang.Object[] getSpans(int arg0, int arg1, java.lang.Class arg2); 
		int getSpanStart(java.lang.Object arg0); 
		int getSpanEnd(java.lang.Object arg0); 
		int getSpanFlags(java.lang.Object arg0); 
		int nextSpanTransition(int arg0, int arg1, java.lang.Class arg2); 
	} 
} 
