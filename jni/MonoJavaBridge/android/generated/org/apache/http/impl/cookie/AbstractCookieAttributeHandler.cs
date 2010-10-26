namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_))]
	public abstract partial class AbstractCookieAttributeHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCookieAttributeHandler()
		{
			InitJNI();
		}
		protected AbstractCookieAttributeHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33194;
		public abstract void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _match33195;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._match33195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._match33195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33196;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._validate33196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._validate33196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCookieAttributeHandler33197;
		public AbstractCookieAttributeHandler()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._AbstractCookieAttributeHandler33197);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieAttributeHandler"));
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._parse33194 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._match33195 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._validate33196 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler._AbstractCookieAttributeHandler33197 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler))]
	internal sealed partial class AbstractCookieAttributeHandler_ : org.apache.http.impl.cookie.AbstractCookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractCookieAttributeHandler_()
		{
			InitJNI();
		}
		internal AbstractCookieAttributeHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33198;
		public override void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_._parse33198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_.staticClass, global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_._parse33198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieAttributeHandler"));
			global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_._parse33198 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieAttributeHandler_.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
		}
	}
}
