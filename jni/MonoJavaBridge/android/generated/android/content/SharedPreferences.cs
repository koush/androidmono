namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_))]
	public interface SharedPreferences  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class SharedPreferences_ : java.lang.Object, SharedPreferences
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SharedPreferences_()
		{
			InitJNI();
		}
		internal SharedPreferences_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean1766;
		 bool android.content.SharedPreferences.getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_._getBoolean1766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._getBoolean1766, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt1767;
		 int android.content.SharedPreferences.getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SharedPreferences_._getInt1767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._getInt1767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong1768;
		 long android.content.SharedPreferences.getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.content.SharedPreferences_._getLong1768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._getLong1768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat1769;
		 float android.content.SharedPreferences.getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.SharedPreferences_._getFloat1769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._getFloat1769, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _contains1770;
		 bool android.content.SharedPreferences.contains(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_._contains1770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._contains1770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getString1771;
		 global::java.lang.String android.content.SharedPreferences.getString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_._getString1771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._getString1771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _edit1772;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences.edit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_._edit1772)) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._edit1772)) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _getAll1773;
		 global::java.util.Map android.content.SharedPreferences.getAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_._getAll1773)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._getAll1773)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _registerOnSharedPreferenceChangeListener1774;
		 void android.content.SharedPreferences.registerOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_._registerOnSharedPreferenceChangeListener1774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._registerOnSharedPreferenceChangeListener1774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterOnSharedPreferenceChangeListener1775;
		 void android.content.SharedPreferences.unregisterOnSharedPreferenceChangeListener(android.content.SharedPreferences_OnSharedPreferenceChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_._unregisterOnSharedPreferenceChangeListener1775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SharedPreferences_.staticClass, global::android.content.SharedPreferences_._unregisterOnSharedPreferenceChangeListener1775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences"));
			global::android.content.SharedPreferences_._getBoolean1766 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::android.content.SharedPreferences_._getInt1767 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::android.content.SharedPreferences_._getLong1768 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::android.content.SharedPreferences_._getFloat1769 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::android.content.SharedPreferences_._contains1770 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "contains", "(Ljava/lang/String;)Z");
			global::android.content.SharedPreferences_._getString1771 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			global::android.content.SharedPreferences_._edit1772 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "edit", "()Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_._getAll1773 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "getAll", "()Ljava/util/Map;");
			global::android.content.SharedPreferences_._registerOnSharedPreferenceChangeListener1774 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "registerOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V");
			global::android.content.SharedPreferences_._unregisterOnSharedPreferenceChangeListener1775 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_.staticClass, "unregisterOnSharedPreferenceChangeListener", "(Landroid/content/SharedPreferences$OnSharedPreferenceChangeListener;)V");
		}
	}
}
