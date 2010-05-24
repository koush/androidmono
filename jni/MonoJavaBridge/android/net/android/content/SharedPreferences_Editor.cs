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

	public partial class SharedPreferences_Editor_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SharedPreferences_Editor.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SharedPreferences_Editor : java.lang.Object, SharedPreferences_Editor
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SharedPreferences_Editor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.__SharedPreferences_Editor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.__SharedPreferences_Editor(@__env); 
			} 
		} 
		internal __SharedPreferences_Editor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putBoolean1493; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putBoolean(java.lang.String arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _putBoolean1493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _putBoolean1493, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putInt1494; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putInt(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _putInt1494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _putInt1494, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putLong1495; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putLong(java.lang.String arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _putLong1495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _putLong1495, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putFloat1496; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putFloat(java.lang.String arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _putFloat1496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _putFloat1496, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clear1497; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.clear() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _clear1497)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _clear1497)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _remove1498; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.remove(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _remove1498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _remove1498, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _putString1499; 
		 android.content.SharedPreferences_Editor android.content.SharedPreferences_Editor.putString(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallObjectMethodPtr(this, _putString1499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.content.SharedPreferences_Editor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.__SharedPreferences_Editor.staticClass, _putString1499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _commit1500; 
		 bool android.content.SharedPreferences_Editor.commit() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.__SharedPreferences_Editor)) 
				return @__env.CallBooleanMethod(this, _commit1500); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.content.__SharedPreferences_Editor.staticClass, _commit1500); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.__SharedPreferences_Editor.staticClass = @__class; 
			global::android.content.__SharedPreferences_Editor._putBoolean1493 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.putBoolean", "(Ljava/lang/String;Z)Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._putInt1494 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.putInt", "(Ljava/lang/String;I)Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._putLong1495 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.putLong", "(Ljava/lang/String;J)Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._putFloat1496 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.putFloat", "(Ljava/lang/String;F)Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._clear1497 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.clear", "()Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._remove1498 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.remove", "(Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._putString1499 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.putString", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SharedPreferences$Editor;"); 
			global::android.content.__SharedPreferences_Editor._commit1500 = @__env.GetMethodID(global::android.content.__SharedPreferences_Editor.staticClass, "android.content.SharedPreferences_Editor.commit", "()Z"); 
		} 
	} 
} 
