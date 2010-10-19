namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2109DomainHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RFC2109DomainHandler()
		{
			InitJNI();
		}
		protected RFC2109DomainHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse26575;
		public virtual void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2109DomainHandler._parse26575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._parse26575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match26576;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2109DomainHandler._match26576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._match26576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate26577;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2109DomainHandler._validate26577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._validate26577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2109DomainHandler26578;
		public RFC2109DomainHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._RFC2109DomainHandler26578);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2109DomainHandler"));
			global::org.apache.http.impl.cookie.RFC2109DomainHandler._parse26575 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.RFC2109DomainHandler._match26576 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.RFC2109DomainHandler._validate26577 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.RFC2109DomainHandler._RFC2109DomainHandler26578 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "<init>", "()V");
		}
	}
}
