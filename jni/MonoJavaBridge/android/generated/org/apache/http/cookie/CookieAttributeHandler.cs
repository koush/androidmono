namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.CookieAttributeHandler_))]
	public interface CookieAttributeHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1);
		bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.CookieAttributeHandler))]
	public sealed partial class CookieAttributeHandler_ : java.lang.Object, CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieAttributeHandler_()
		{
			InitJNI();
		}
		internal CookieAttributeHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse25674;
		 void org.apache.http.cookie.CookieAttributeHandler.parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_._parse25674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, global::org.apache.http.cookie.CookieAttributeHandler_._parse25674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match25675;
		 bool org.apache.http.cookie.CookieAttributeHandler.match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_._match25675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, global::org.apache.http.cookie.CookieAttributeHandler_._match25675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate25676;
		 void org.apache.http.cookie.CookieAttributeHandler.validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_._validate25676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, global::org.apache.http.cookie.CookieAttributeHandler_._validate25676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieAttributeHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieAttributeHandler"));
			global::org.apache.http.cookie.CookieAttributeHandler_._parse25674 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.cookie.CookieAttributeHandler_._match25675 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.cookie.CookieAttributeHandler_._validate25676 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
		}
	}
}
