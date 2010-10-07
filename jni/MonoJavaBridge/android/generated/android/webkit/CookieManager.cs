namespace android.webkit
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class CookieManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static CookieManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.webkit.CookieManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.webkit.CookieManager(@__env);
			}
		}
		internal CookieManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInstance9949;
		public static global::android.webkit.CookieManager getInstance() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CookieManager>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getInstance9949));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAcceptCookie9950;
		public void setAcceptCookie(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.CookieManager._setAcceptCookie9950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._setAcceptCookie9950, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _acceptCookie9951;
		public bool acceptCookie() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.CookieManager._acceptCookie9951);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._acceptCookie9951);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCookie9952;
		public void setCookie(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.CookieManager._setCookie9952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._setCookie9952, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCookie9953;
		public global::java.lang.String getCookie(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.webkit.CookieManager._getCookie9953, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._getCookie9953, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeSessionCookie9954;
		public void removeSessionCookie() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.CookieManager._removeSessionCookie9954);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeSessionCookie9954);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeAllCookie9955;
		public void removeAllCookie() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.CookieManager._removeAllCookie9955);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeAllCookie9955);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasCookies9956;
		public bool hasCookies() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.webkit.CookieManager._hasCookies9956);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._hasCookies9956);
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeExpiredCookie9957;
		public void removeExpiredCookie() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.webkit.CookieManager._removeExpiredCookie9957);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.webkit.CookieManager.staticClass, global::android.webkit.CookieManager._removeExpiredCookie9957);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.webkit.CookieManager.staticClass = @__class;
			global::android.webkit.CookieManager._getInstance9949 = @__env.GetStaticMethodID(global::android.webkit.CookieManager.staticClass, "getInstance", "()Landroid/webkit/CookieManager;");
			global::android.webkit.CookieManager._setAcceptCookie9950 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "setAcceptCookie", "(Z)V");
			global::android.webkit.CookieManager._acceptCookie9951 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "acceptCookie", "()Z");
			global::android.webkit.CookieManager._setCookie9952 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.CookieManager._getCookie9953 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "getCookie", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.webkit.CookieManager._removeSessionCookie9954 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "removeSessionCookie", "()V");
			global::android.webkit.CookieManager._removeAllCookie9955 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "removeAllCookie", "()V");
			global::android.webkit.CookieManager._hasCookies9956 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "hasCookies", "()Z");
			global::android.webkit.CookieManager._removeExpiredCookie9957 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "removeExpiredCookie", "()V");
		}
	}
}
