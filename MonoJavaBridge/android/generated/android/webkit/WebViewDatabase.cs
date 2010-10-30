namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebViewDatabase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebViewDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.webkit.WebViewDatabase getInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebViewDatabase;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void clearFormData()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V", ref global::android.webkit.WebViewDatabase._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual bool hasUsernamePassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z", ref global::android.webkit.WebViewDatabase._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void clearUsernamePassword()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V", ref global::android.webkit.WebViewDatabase._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool hasHttpAuthUsernamePassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z", ref global::android.webkit.WebViewDatabase._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void clearHttpAuthUsernamePassword()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V", ref global::android.webkit.WebViewDatabase._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool hasFormData()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z", ref global::android.webkit.WebViewDatabase._m6);
		}
		static WebViewDatabase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebViewDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebViewDatabase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
