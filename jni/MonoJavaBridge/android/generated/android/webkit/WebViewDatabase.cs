namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebViewDatabase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static WebViewDatabase()
		{
			InitJNI();
		}
		protected WebViewDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16369;
		public static global::android.webkit.WebViewDatabase getInstance(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._getInstance16369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebViewDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData16370;
		public virtual void clearFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._clearFormData16370);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearFormData16370);
		}
		internal static global::MonoJavaBridge.MethodId _hasUsernamePassword16371;
		public virtual bool hasUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._hasUsernamePassword16371);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasUsernamePassword16371);
		}
		internal static global::MonoJavaBridge.MethodId _clearUsernamePassword16372;
		public virtual void clearUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._clearUsernamePassword16372);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearUsernamePassword16372);
		}
		internal static global::MonoJavaBridge.MethodId _hasHttpAuthUsernamePassword16373;
		public virtual bool hasHttpAuthUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword16373);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword16373);
		}
		internal static global::MonoJavaBridge.MethodId _clearHttpAuthUsernamePassword16374;
		public virtual void clearHttpAuthUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword16374);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword16374);
		}
		internal static global::MonoJavaBridge.MethodId _hasFormData16375;
		public virtual bool hasFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._hasFormData16375);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasFormData16375);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebViewDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebViewDatabase"));
			global::android.webkit.WebViewDatabase._getInstance16369 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;");
			global::android.webkit.WebViewDatabase._clearFormData16370 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V");
			global::android.webkit.WebViewDatabase._hasUsernamePassword16371 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearUsernamePassword16372 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword16373 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword16374 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasFormData16375 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z");
		}
	}
}
