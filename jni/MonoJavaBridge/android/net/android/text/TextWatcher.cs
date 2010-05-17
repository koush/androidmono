namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface TextWatcher : NoCopySpan
	{ 
		void onTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3); 
		void beforeTextChanged(java.lang.CharSequence arg0, int arg1, int arg2, int arg3); 
		void afterTextChanged(android.text.Editable arg0); 
	} 
} 
