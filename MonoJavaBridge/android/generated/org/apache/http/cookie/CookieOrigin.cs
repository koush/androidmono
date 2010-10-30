namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class CookieOrigin : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieOrigin(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32410;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.CookieOrigin.staticClass, "toString", "()Ljava/lang/String;", ref global::org.apache.http.cookie.CookieOrigin._toString32410) as java.lang.String;
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath32411;
		public global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.CookieOrigin.staticClass, "getPath", "()Ljava/lang/String;", ref global::org.apache.http.cookie.CookieOrigin._getPath32411) as java.lang.String;
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort32412;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.cookie.CookieOrigin.staticClass, "getPort", "()I", ref global::org.apache.http.cookie.CookieOrigin._getPort32412);
		}
		public new global::java.lang.String Host
		{
			get
			{
				return getHost();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getHost32413;
		public global::java.lang.String getHost()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.cookie.CookieOrigin.staticClass, "getHost", "()Ljava/lang/String;", ref global::org.apache.http.cookie.CookieOrigin._getHost32413) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSecure32414;
		public bool isSecure()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.cookie.CookieOrigin.staticClass, "isSecure", "()Z", ref global::org.apache.http.cookie.CookieOrigin._isSecure32414);
		}
		internal static global::MonoJavaBridge.MethodId _CookieOrigin32415;
		public CookieOrigin(java.lang.String arg0, int arg1, java.lang.String arg2, bool arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.CookieOrigin._CookieOrigin32415.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.CookieOrigin._CookieOrigin32415 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieOrigin.staticClass, "<init>", "(Ljava/lang/String;ILjava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.cookie.CookieOrigin.staticClass, global::org.apache.http.cookie.CookieOrigin._CookieOrigin32415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static CookieOrigin()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieOrigin.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieOrigin"));
		}
		internal static void InitJNI()
		{
		}
	}
}
