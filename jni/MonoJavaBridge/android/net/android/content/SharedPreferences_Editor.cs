namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SharedPreferences_Editor 
	{ 
		android.content.SharedPreferences_Editor putBoolean(java.lang.String arg0, bool arg1); 
		android.content.SharedPreferences_Editor putInt(java.lang.String arg0, int arg1); 
		android.content.SharedPreferences_Editor putLong(java.lang.String arg0, long arg1); 
		android.content.SharedPreferences_Editor putFloat(java.lang.String arg0, float arg1); 
		android.content.SharedPreferences_Editor clear(); 
		android.content.SharedPreferences_Editor remove(java.lang.String arg0); 
		android.content.SharedPreferences_Editor putString(java.lang.String arg0, java.lang.String arg1); 
		bool commit(); 
	} 
} 
