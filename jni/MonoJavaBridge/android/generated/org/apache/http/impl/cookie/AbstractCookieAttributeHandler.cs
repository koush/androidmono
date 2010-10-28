namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_))]
	public abstract partial class AbstractCookieAttributeHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractCookieAttributeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33195;
		public abstract void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _match33196;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._match33196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._match33196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33197;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._validate33197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._validate33197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCookieAttributeHandler33198;
		public AbstractCookieAttributeHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._AbstractCookieAttributeHandler33198);
			Init(@__env, handle);
		}
		static AbstractCookieAttributeHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieAttributeHandler"));
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._parse33195 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._match33196 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._validate33197 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._AbstractCookieAttributeHandler33198 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler))]
	internal sealed partial class AbstractCookieAttributeHandler_ : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractCookieAttributeHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33199;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_._parse33199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_._parse33199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static AbstractCookieAttributeHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieAttributeHandler"));
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_._parse33199 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
