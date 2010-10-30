namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2109VersionHandler : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2109VersionHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33336;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109VersionHandler._parse33336.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109VersionHandler._parse33336 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109VersionHandler._parse33336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33337;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109VersionHandler._validate33337.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109VersionHandler._validate33337 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109VersionHandler._validate33337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2109VersionHandler33338;
		public RFC2109VersionHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109VersionHandler._RFC2109VersionHandler33338.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109VersionHandler._RFC2109VersionHandler33338 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109VersionHandler._RFC2109VersionHandler33338);
			Init(@__env, handle);
		}
		static RFC2109VersionHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2109VersionHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2109VersionHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
