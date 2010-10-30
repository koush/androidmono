namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicSecureHandler : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicSecureHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33265;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.BasicSecureHandler._parse33265.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.BasicSecureHandler._parse33265 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, global::org.apache.http.impl.cookie.BasicSecureHandler._parse33265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match33266;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.BasicSecureHandler._match33266.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.BasicSecureHandler._match33266 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, global::org.apache.http.impl.cookie.BasicSecureHandler._match33266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _BasicSecureHandler33267;
		public BasicSecureHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.BasicSecureHandler._BasicSecureHandler33267.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.BasicSecureHandler._BasicSecureHandler33267 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.BasicSecureHandler.staticClass, global::org.apache.http.impl.cookie.BasicSecureHandler._BasicSecureHandler33267);
			Init(@__env, handle);
		}
		static BasicSecureHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.BasicSecureHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/BasicSecureHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
