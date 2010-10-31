namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::android.webkit.CookieManager Instance
		{
			get
			{
				return getInstance();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.webkit.CookieManager getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CookieManager._m0.native == global::System.IntPtr.Zero)
				global::android.webkit.CookieManager._m0 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "getInstance", "()Landroid/webkit/CookieManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieManager>(@__env.CallStaticObjectMethod(android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._m0)) as android.webkit.CookieManager;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public void setAcceptCookie(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "setAcceptCookie", "(Z)V", ref global::android.webkit.CookieManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public bool acceptCookie()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.CookieManager.staticClass, "acceptCookie", "()Z", ref global::android.webkit.CookieManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void setCookie(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.CookieManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public global::java.lang.String getCookie(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CookieManager.staticClass, "getCookie", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.webkit.CookieManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void removeSessionCookie()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "removeSessionCookie", "()V", ref global::android.webkit.CookieManager._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void removeAllCookie()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "removeAllCookie", "()V", ref global::android.webkit.CookieManager._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public bool hasCookies()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.CookieManager.staticClass, "hasCookies", "()Z", ref global::android.webkit.CookieManager._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void removeExpiredCookie()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "removeExpiredCookie", "()V", ref global::android.webkit.CookieManager._m8);
		}
		static CookieManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieManager"));
		}
	}
}
