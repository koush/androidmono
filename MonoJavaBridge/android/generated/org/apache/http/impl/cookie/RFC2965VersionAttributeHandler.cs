namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965VersionAttributeHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2965VersionAttributeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33366;
		public virtual void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._parse33366.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._parse33366 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._parse33366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match33367;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._match33367.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._match33367 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._match33367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33368;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._validate33368.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._validate33368 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._validate33368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965VersionAttributeHandler33369;
		public RFC2965VersionAttributeHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._RFC2965VersionAttributeHandler33369.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._RFC2965VersionAttributeHandler33369 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler._RFC2965VersionAttributeHandler33369);
			Init(@__env, handle);
		}
		static RFC2965VersionAttributeHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965VersionAttributeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965VersionAttributeHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
