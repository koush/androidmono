namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_Editor_))]
	public partial interface SharedPreferences_Editor  : global::MonoJavaBridge.IJavaObject 
	{
		global::android.content.SharedPreferences_Editor putBoolean(java.lang.String arg0, bool arg1);
		global::android.content.SharedPreferences_Editor putInt(java.lang.String arg0, int arg1);
		global::android.content.SharedPreferences_Editor putLong(java.lang.String arg0, long arg1);
		global::android.content.SharedPreferences_Editor putFloat(java.lang.String arg0, float arg1);
		global::android.content.SharedPreferences_Editor clear();
		global::android.content.SharedPreferences_Editor remove(java.lang.String arg0);
		global::android.content.SharedPreferences_Editor putString(java.lang.String arg0, java.lang.String arg1);
		bool commit();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.SharedPreferences_Editor))]
	public sealed partial class SharedPreferences_Editor_ : java.lang.Object, SharedPreferences_Editor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SharedPreferences_Editor_()
		{
			InitJNI();
		}
		internal SharedPreferences_Editor_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean3497;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putBoolean3497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putBoolean3497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putInt3498;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putInt3498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putInt3498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putLong3499;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putLong3499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putLong3499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat3500;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putFloat3500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putFloat3500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _clear3501;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._clear3501)) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._clear3501)) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _remove3502;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._remove3502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._remove3502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putString3503;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putString3503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putString3503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _commit3504;
		 bool android.content.SharedPreferences_Editor.commit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._commit3504);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._commit3504);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_Editor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences_Editor"));
			global::android.content.SharedPreferences_Editor_._putBoolean3497 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putInt3498 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putLong3499 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putFloat3500 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._clear3501 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "clear", "()Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._remove3502 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putString3503 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._commit3504 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "commit", "()Z");
		}
	}
}
