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
		internal static global::MonoJavaBridge.MethodId _getInstance11236;
		public static global::android.webkit.WebViewDatabase getInstance(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._getInstance11236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebViewDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData11237;
		public virtual void clearFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._clearFormData11237);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearFormData11237);
		}
		internal static global::MonoJavaBridge.MethodId _hasUsernamePassword11238;
		public virtual bool hasUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._hasUsernamePassword11238);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasUsernamePassword11238);
		}
		internal static global::MonoJavaBridge.MethodId _clearUsernamePassword11239;
		public virtual void clearUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._clearUsernamePassword11239);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearUsernamePassword11239);
		}
		internal static global::MonoJavaBridge.MethodId _hasHttpAuthUsernamePassword11240;
		public virtual bool hasHttpAuthUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword11240);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword11240);
		}
		internal static global::MonoJavaBridge.MethodId _clearHttpAuthUsernamePassword11241;
		public virtual void clearHttpAuthUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword11241);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword11241);
		}
		internal static global::MonoJavaBridge.MethodId _hasFormData11242;
		public virtual bool hasFormData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase._hasFormData11242);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasFormData11242);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebViewDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebViewDatabase"));
			global::android.webkit.WebViewDatabase._getInstance11236 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;");
			global::android.webkit.WebViewDatabase._clearFormData11237 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V");
			global::android.webkit.WebViewDatabase._hasUsernamePassword11238 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearUsernamePassword11239 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword11240 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z");
			global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword11241 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V");
			global::android.webkit.WebViewDatabase._hasFormData11242 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z");
		}
	}
}
