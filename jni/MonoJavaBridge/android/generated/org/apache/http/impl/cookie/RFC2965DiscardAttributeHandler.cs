namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965DiscardAttributeHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RFC2965DiscardAttributeHandler()
		{
			InitJNI();
		}
		protected RFC2965DiscardAttributeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse26597;
		public virtual void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._parse26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._parse26597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match26598;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._match26598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._match26598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate26599;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._validate26599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._validate26599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965DiscardAttributeHandler26600;
		public RFC2965DiscardAttributeHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._RFC2965DiscardAttributeHandler26600);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965DiscardAttributeHandler"));
			global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._parse26597 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._match26598 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._validate26599 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler._RFC2965DiscardAttributeHandler26600 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965DiscardAttributeHandler.staticClass, "<init>", "()V");
		}
	}
}
