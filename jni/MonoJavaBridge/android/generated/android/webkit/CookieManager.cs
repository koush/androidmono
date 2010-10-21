namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieManager()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getInstance15941;
		public static global::android.webkit.CookieManager getInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getInstance15941)) as android.webkit.CookieManager;
		}
		internal static global::MonoJavaBridge.MethodId _setAcceptCookie15942;
		public void setAcceptCookie(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._setAcceptCookie15942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._setAcceptCookie15942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _acceptCookie15943;
		public bool acceptCookie() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager._acceptCookie15943);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._acceptCookie15943);
		}
		internal static global::MonoJavaBridge.MethodId _setCookie15944;
		public void setCookie(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._setCookie15944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._setCookie15944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCookie15945;
		public global::java.lang.String getCookie(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.webkit.CookieManager._getCookie15945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getCookie15945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _removeSessionCookie15946;
		public void removeSessionCookie() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._removeSessionCookie15946);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeSessionCookie15946);
		}
		internal static global::MonoJavaBridge.MethodId _removeAllCookie15947;
		public void removeAllCookie() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._removeAllCookie15947);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeAllCookie15947);
		}
		internal static global::MonoJavaBridge.MethodId _hasCookies15948;
		public bool hasCookies() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager._hasCookies15948);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._hasCookies15948);
		}
		internal static global::MonoJavaBridge.MethodId _removeExpiredCookie15949;
		public void removeExpiredCookie() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.CookieManager._removeExpiredCookie15949);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeExpiredCookie15949);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.CookieManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/CookieManager"));
			global::android.webkit.CookieManager._getInstance15941 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "getInstance", "()Landroid/webkit/CookieManager;");
			global::android.webkit.CookieManager._setAcceptCookie15942 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "setAcceptCookie", "(Z)V");
			global::android.webkit.CookieManager._acceptCookie15943 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "acceptCookie", "()Z");
			global::android.webkit.CookieManager._setCookie15944 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.CookieManager._getCookie15945 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "getCookie", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.CookieManager._removeSessionCookie15946 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "removeSessionCookie", "()V");
			global::android.webkit.CookieManager._removeAllCookie15947 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "removeAllCookie", "()V");
			global::android.webkit.CookieManager._hasCookies15948 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "hasCookies", "()Z");
			global::android.webkit.CookieManager._removeExpiredCookie15949 = @__env.GetMethodIDNoThrow(global::android.webkit.CookieManager.staticClass, "removeExpiredCookie", "()V");
		}
	}
}
