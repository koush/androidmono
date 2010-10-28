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
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.webkit.CookieManager>(@__env.CallStaticObjectMethod(android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getInstance16024)) as android.webkit.CookieManager;
		}
		internal static global::MonoJavaBridge.MethodId _setAcceptCookie16025;
		public void setAcceptCookie(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._setAcceptCookie16025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._setAcceptCookie16025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acceptCookie16026;
		public bool acceptCookie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager._acceptCookie16026);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._acceptCookie16026);
		}
		internal static global::MonoJavaBridge.MethodId _setCookie16027;
		public void setCookie(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._setCookie16027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._setCookie16027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCookie16028;
		public global::java.lang.String getCookie(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CookieManager._getCookie16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getCookie16028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeSessionCookie16029;
		public void removeSessionCookie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._removeSessionCookie16029);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeSessionCookie16029);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllCookie16030;
		public void removeAllCookie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._removeAllCookie16030);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeAllCookie16030);
		}
		internal static global::MonoJavaBridge.MethodId _hasCookies16031;
		public bool hasCookies()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager._hasCookies16031);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._hasCookies16031);
		}
		internal static global::MonoJavaBridge.MethodId _removeExpiredCookie16032;
		public void removeExpiredCookie()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._removeExpiredCookie16032);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeExpiredCookie16032);
		}
		static CookieManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieManager"));
			global::android.webkit.CookieManager._getInstance16024 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "getInstance", "()Landroid/webkit/CookieManager;");
			global::android.webkit.CookieManager._setAcceptCookie16025 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "setAcceptCookie", "(Z)V");
			global::android.webkit.CookieManager._acceptCookie16026 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "acceptCookie", "()Z");
			global::android.webkit.CookieManager._setCookie16027 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.CookieManager._getCookie16028 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "getCookie", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.CookieManager._removeSessionCookie16029 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "removeSessionCookie", "()V");
			global::android.webkit.CookieManager._removeAllCookie16030 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "removeAllCookie", "()V");
			global::android.webkit.CookieManager._hasCookies16031 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "hasCookies", "()Z");
			global::android.webkit.CookieManager._removeExpiredCookie16032 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "removeExpiredCookie", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
