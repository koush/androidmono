namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class WebViewDatabase : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static WebViewDatabase() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.WebViewDatabase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.webkit.WebViewDatabase(@__env); 
			} 
		} 
		protected WebViewDatabase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8954; 
		public static android.webkit.WebViewDatabase getInstance(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.WebViewDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.WebViewDatabase.staticClass, _getInstance8954, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearFormData8955; 
		public virtual void clearFormData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewDatabase)) 
				@__env.CallVoidMethod(this, _clearFormData8955); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewDatabase.staticClass, _clearFormData8955); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasUsernamePassword8956; 
		public virtual bool hasUsernamePassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewDatabase)) 
				return @__env.CallBooleanMethod(this, _hasUsernamePassword8956); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebViewDatabase.staticClass, _hasUsernamePassword8956); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearUsernamePassword8957; 
		public virtual void clearUsernamePassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewDatabase)) 
				@__env.CallVoidMethod(this, _clearUsernamePassword8957); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewDatabase.staticClass, _clearUsernamePassword8957); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasHttpAuthUsernamePassword8958; 
		public virtual bool hasHttpAuthUsernamePassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewDatabase)) 
				return @__env.CallBooleanMethod(this, _hasHttpAuthUsernamePassword8958); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebViewDatabase.staticClass, _hasHttpAuthUsernamePassword8958); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearHttpAuthUsernamePassword8959; 
		public virtual void clearHttpAuthUsernamePassword() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewDatabase)) 
				@__env.CallVoidMethod(this, _clearHttpAuthUsernamePassword8959); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.WebViewDatabase.staticClass, _clearHttpAuthUsernamePassword8959); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFormData8960; 
		public virtual bool hasFormData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.WebViewDatabase)) 
				return @__env.CallBooleanMethod(this, _hasFormData8960); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.WebViewDatabase.staticClass, _hasFormData8960); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.WebViewDatabase.staticClass = @__class; 
			global::android.webkit.WebViewDatabase._getInstance8954 = @__env.GetStaticMethodID(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;"); 
			global::android.webkit.WebViewDatabase._clearFormData8955 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V"); 
			global::android.webkit.WebViewDatabase._hasUsernamePassword8956 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z"); 
			global::android.webkit.WebViewDatabase._clearUsernamePassword8957 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V"); 
			global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword8958 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z"); 
			global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword8959 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V"); 
			global::android.webkit.WebViewDatabase._hasFormData8960 = @__env.GetMethodID(global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z"); 
		} 
	} 
} 
