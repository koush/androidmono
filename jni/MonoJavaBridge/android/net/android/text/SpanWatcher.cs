namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SpanWatcher : NoCopySpan
	{ 
		void onSpanAdded(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3); 
		void onSpanRemoved(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3); 
		void onSpanChanged(android.text.Spannable arg0, java.lang.Object arg1, int arg2, int arg3, int arg4, int arg5); 
	} 
} 
