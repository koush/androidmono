namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Editable : java.lang.CharSequence, GetChars, Spannable, java.lang.Appendable
	{ 
		void clear(); 
		new android.text.Editable append(java.lang.CharSequence arg0, int arg1, int arg2); 
		new android.text.Editable append(java.lang.CharSequence arg0); 
		new android.text.Editable append(char arg0); 
		android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2, int arg3, int arg4); 
		android.text.Editable replace(int arg0, int arg1, java.lang.CharSequence arg2); 
		android.text.Editable delete(int arg0, int arg1); 
		android.text.Editable insert(int arg0, java.lang.CharSequence arg1); 
		android.text.Editable insert(int arg0, java.lang.CharSequence arg1, int arg2, int arg3); 
		void setFilters(android.text.InputFilter[] arg0); 
		android.text.InputFilter[] getFilters(); 
		void clearSpans(); 
	} 
} 
