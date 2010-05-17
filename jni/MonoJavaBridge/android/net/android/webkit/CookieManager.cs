namespace android.webkit 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class CookieManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CookieManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.webkit.CookieManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getInstance8588; 
		public static android.webkit.CookieManager getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.webkit.CookieManager>(@__env, @__env.CallStaticObjectMethodPtr(android.webkit.CookieManager.staticClass, _getInstance8588)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAcceptCookie8589; 
		public void setAcceptCookie(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				@__env.CallVoidMethod(this, _setAcceptCookie8589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CookieManager.staticClass, _setAcceptCookie8589, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _acceptCookie8590; 
		public bool acceptCookie() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				return @__env.CallBooleanMethod(this, _acceptCookie8590); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CookieManager.staticClass, _acceptCookie8590); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCookie8591; 
		public void setCookie(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				@__env.CallVoidMethod(this, _setCookie8591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CookieManager.staticClass, _setCookie8591, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCookie8592; 
		public java.lang.String getCookie(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCookie8592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.webkit.CookieManager.staticClass, _getCookie8592, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeSessionCookie8593; 
		public void removeSessionCookie() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				@__env.CallVoidMethod(this, _removeSessionCookie8593); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CookieManager.staticClass, _removeSessionCookie8593); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeAllCookie8594; 
		public void removeAllCookie() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				@__env.CallVoidMethod(this, _removeAllCookie8594); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CookieManager.staticClass, _removeAllCookie8594); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasCookies8595; 
		public bool hasCookies() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				return @__env.CallBooleanMethod(this, _hasCookies8595); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.webkit.CookieManager.staticClass, _hasCookies8595); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _removeExpiredCookie8596; 
		public void removeExpiredCookie() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.webkit.CookieManager)) 
				@__env.CallVoidMethod(this, _removeExpiredCookie8596); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.webkit.CookieManager.staticClass, _removeExpiredCookie8596); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.webkit.CookieManager.staticClass = @__class; 
			global::android.webkit.CookieManager._getInstance8588 = @__env.GetStaticMethodID(global::android.webkit.CookieManager.staticClass, "getInstance", "()Landroid/webkit/CookieManager;"); 
			global::android.webkit.CookieManager._setAcceptCookie8589 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "setAcceptCookie", "(Z)V"); 
			global::android.webkit.CookieManager._acceptCookie8590 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "acceptCookie", "()Z"); 
			global::android.webkit.CookieManager._setCookie8591 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "setCookie", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.webkit.CookieManager._getCookie8592 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "getCookie", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.webkit.CookieManager._removeSessionCookie8593 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "removeSessionCookie", "()V"); 
			global::android.webkit.CookieManager._removeAllCookie8594 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "removeAllCookie", "()V"); 
			global::android.webkit.CookieManager._hasCookies8595 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "hasCookies", "()Z"); 
			global::android.webkit.CookieManager._removeExpiredCookie8596 = @__env.GetMethodID(global::android.webkit.CookieManager.staticClass, "removeExpiredCookie", "()V"); 
		} 
	} 
} 
