namespace android.content
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.content.SharedPreferences_Editor_))]
	public interface SharedPreferences_Editor  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _putBoolean1757;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putBoolean1757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putBoolean1757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putInt1758;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putInt1758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putInt1758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putLong1759;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putLong1759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putLong1759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putFloat1760;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putFloat1760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putFloat1760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _clear1761;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._clear1761)) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._clear1761)) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _remove1762;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._remove1762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._remove1762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _putString1763;
		 global::android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._putString1763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.content.SharedPreferences_Editor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._putString1763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SharedPreferences_Editor;
		}
		internal static global::MonoJavaBridge.MethodId _commit1764;
		 bool android.content.SharedPreferences_Editor.commit() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_._commit1764);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SharedPreferences_Editor_.staticClass, global::android.content.SharedPreferences_Editor_._commit1764);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SharedPreferences_Editor_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SharedPreferences_Editor"));
			global::android.content.SharedPreferences_Editor_._putBoolean1757 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putInt1758 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putLong1759 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putFloat1760 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._clear1761 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "clear", "()Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._remove1762 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._putString1763 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;");
			global::android.content.SharedPreferences_Editor_._commit1764 = @__env.GetMethodIDNoThrow(global::android.content.SharedPreferences_Editor_.staticClass, "commit", "()Z");
		}
	}
}
