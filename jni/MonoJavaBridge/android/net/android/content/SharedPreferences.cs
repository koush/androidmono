namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SharedPreferences 
	{ 
		bool getBoolean(java.lang.String arg0, bool arg1); 
		int getInt(java.lang.String arg0, int arg1); 
		long getLong(java.lang.String arg0, long arg1); 
		float getFloat(java.lang.String arg0, float arg1); 
		bool contains(java.lang.String arg0); 
		java.lang.String getString(java.lang.String arg0, java.lang.String arg1); 
		android.content.SharedPreferences_Editor edit(); 
		java.util.Map getAll(); 
		void registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0); 
		void unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0); 
	} 
} 
