namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965DomainAttributeHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2965DomainAttributeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33347;
		public virtual void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._parse33347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match33348;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._match33348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33349;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._validate33349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _domainMatch33350;
		public virtual bool domainMatch(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._domainMatch33350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965DomainAttributeHandler33351;
		public RFC2965DomainAttributeHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._RFC2965DomainAttributeHandler33351);
			Init(@__env, handle);
		}
		static RFC2965DomainAttributeHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965DomainAttributeHandler"));
			global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._parse33347 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._match33348 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._validate33349 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._domainMatch33350 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, "domainMatch", "(Ljava/lang/String;Ljava/lang/String;)Z");
			global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler._RFC2965DomainAttributeHandler33351 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DomainAttributeHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
