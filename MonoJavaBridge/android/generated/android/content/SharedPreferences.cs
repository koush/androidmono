namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_))]
	public partial interface SharedPreferences  : global::MonoJavaBridge.IJavaObject 
	{
		bool getBoolean(java.lang.String arg0, bool arg1);
		int getInt(java.lang.String arg0, int arg1);
		long getLong(java.lang.String arg0, long arg1);
		float getFloat(java.lang.String arg0, float arg1);
		bool contains(java.lang.String arg0);
		global::java.lang.String getString(java.lang.String arg0, java.lang.String arg1);
		global::android.content.SharedPreferences_Editor edit();
		global::java.util.Map getAll();
		void registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0);
		void unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SharedPreferences))]
	internal sealed partial class SharedPreferences_ : java.lang.Object, SharedPreferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SharedPreferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool android.content.SharedPreferences.getBoolean(java.lang.String arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SharedPreferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z", ref global::android.content.SharedPreferences_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int android.content.SharedPreferences.getInt(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.SharedPreferences_.staticClass, "getInt", "(Ljava/lang/String;I)I", ref global::android.content.SharedPreferences_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		long android.content.SharedPreferences.getLong(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.content.SharedPreferences_.staticClass, "getLong", "(Ljava/lang/String;J)J", ref global::android.content.SharedPreferences_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		float android.content.SharedPreferences.getFloat(java.lang.String arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.SharedPreferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F", ref global::android.content.SharedPreferences_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool android.content.SharedPreferences.contains(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.SharedPreferences_.staticClass, "contains", "(Ljava/lang/String;)Z", ref global::android.content.SharedPreferences_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String android.content.SharedPreferences.getString(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.SharedPreferences_.staticClass, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", ref global::android.content.SharedPreferences_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::android.content.SharedPreferences_Editor android.content.SharedPreferences.edit()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.SharedPreferences_Editor>(this, global::android.content.SharedPreferences_.staticClass, "edit", "()Landroid/content/SharedPreferences$Editor;", ref global::android.content.SharedPreferences_._m6) as android.content.SharedPreferences_Editor;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.util.Map android.content.SharedPreferences.getAll()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::android.content.SharedPreferences_.staticClass, "getAll", "()Ljava/util/Map;", ref global::android.content.SharedPreferences_._m7) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void android.content.SharedPreferences.registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SharedPreferences_.staticClass, "registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", ref global::android.content.SharedPreferences_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void android.content.SharedPreferences.unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.SharedPreferences_.staticClass, "unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V", ref global::android.content.SharedPreferences_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static SharedPreferences_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences"));
		}
		internal static void InitJNI()
		{
		}
	}
}
