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
		internal static global::MonoJavaBridge.MethodId _getInstance16024;
		public static global::android.webkit.CookieManager getInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.CookieManager._getInstance16024.native == global::System.IntPtr.Zero)
				global::android.webkit.CookieManager._getInstance16024 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "getInstance", "()Landroid/webkit/CookieManager;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieManager>(@__env.CallStaticObjectMethod(android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getInstance16024)) as android.webkit.CookieManager;
		}
		internal static global::MonoJavaBridge.MethodId _setAcceptCookie16025;
		public void setAcceptCookie(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "setAcceptCookie", "(Z)V", ref global::android.webkit.CookieManager._setAcceptCookie16025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acceptCookie16026;
		public bool acceptCookie()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.CookieManager.staticClass, "acceptCookie", "()Z", ref global::android.webkit.CookieManager._acceptCookie16026);
		}
		internal static global::MonoJavaBridge.MethodId _setCookie16027;
		public void setCookie(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.webkit.CookieManager._setCookie16027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCookie16028;
		public global::java.lang.String getCookie(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.webkit.CookieManager.staticClass, "getCookie", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.webkit.CookieManager._getCookie16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeSessionCookie16029;
		public void removeSessionCookie()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "removeSessionCookie", "()V", ref global::android.webkit.CookieManager._removeSessionCookie16029);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllCookie16030;
		public void removeAllCookie()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "removeAllCookie", "()V", ref global::android.webkit.CookieManager._removeAllCookie16030);
		}
		internal static global::MonoJavaBridge.MethodId _hasCookies16031;
		public bool hasCookies()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.CookieManager.staticClass, "hasCookies", "()Z", ref global::android.webkit.CookieManager._hasCookies16031);
		}
		internal static global::MonoJavaBridge.MethodId _removeExpiredCookie16032;
		public void removeExpiredCookie()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.CookieManager.staticClass, "removeExpiredCookie", "()V", ref global::android.webkit.CookieManager._removeExpiredCookie16032);
		}
		static CookieManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
