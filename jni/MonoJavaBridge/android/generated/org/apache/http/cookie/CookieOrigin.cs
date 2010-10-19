namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieOrigin : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieOrigin()
		{
			InitJNI();
		}
		internal CookieOrigin(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString25680;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._toString25680)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._toString25680)) as java.lang.String;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath25681;
		public global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._getPath25681)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._getPath25681)) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort25682;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._getPort25682);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._getPort25682);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost25683;
		public global::java.lang.String getHost() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._getHost25683)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._getHost25683)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure25684;
		public bool isSecure() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin._isSecure25684);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._isSecure25684);
		}
		internal static global::MonoJavaBridge.MethodId _CookieOrigin25685;
		public CookieOrigin(java.lang.String arg0, int arg1, java.lang.String arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._CookieOrigin25685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieOrigin.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieOrigin"));
			global::org.apache.http.cookie.CookieOrigin._toString25680 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.cookie.CookieOrigin._getPath25681 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "getPath", "()Ljava/lang/String;");
			global::org.apache.http.cookie.CookieOrigin._getPort25682 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "getPort", "()I");
			global::org.apache.http.cookie.CookieOrigin._getHost25683 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "getHost", "()Ljava/lang/String;");
			global::org.apache.http.cookie.CookieOrigin._isSecure25684 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "isSecure", "()Z");
			global::org.apache.http.cookie.CookieOrigin._CookieOrigin25685 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V");
		}
	}
}
