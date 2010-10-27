namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.cookie.CookieSpecBase_))]
	public abstract partial class CookieSpecBase : org.apache.http.impl.cookie.AbstractCookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieSpecBase()
		{
			InitJNI();
		}
		protected CookieSpecBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultDomain33285;
		protected static global::java.lang.String getDefaultDomain(org.apache.http.cookie.CookieOrigin arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultDomain33285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse33286;
		protected virtual global::java.util.List parse(org.apache.http.HeaderElement[] arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase._parse33286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._parse33286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match33287;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase._match33287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._match33287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33288;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase._validate33288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._validate33288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPath33289;
		protected static global::java.lang.String getDefaultPath(org.apache.http.cookie.CookieOrigin arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultPath33289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CookieSpecBase33290;
		public CookieSpecBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._CookieSpecBase33290);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.CookieSpecBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/CookieSpecBase"));
			global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultDomain33285 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "getDefaultDomain", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;");
			global::org.apache.http.impl.cookie.CookieSpecBase._parse33286 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "parse", "([Lorg/apache/http/HeaderElement;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.CookieSpecBase._match33287 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.CookieSpecBase._validate33288 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultPath33289 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "getDefaultPath", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;");
			global::org.apache.http.impl.cookie.CookieSpecBase._CookieSpecBase33290 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.cookie.CookieSpecBase))]
	internal sealed partial class CookieSpecBase_ : org.apache.http.impl.cookie.CookieSpecBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CookieSpecBase_()
		{
			InitJNI();
		}
		internal CookieSpecBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33291;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._parse33291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase_._parse33291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33292;
		public override int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._getVersion33292);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase_._getVersion33292);
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33293;
		public override global::java.util.List formatCookies(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._formatCookies33293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase_._formatCookies33293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33294;
		public override global::org.apache.http.Header getVersionHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._getVersionHeader33294)) as org.apache.http.Header;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase_._getVersionHeader33294)) as org.apache.http.Header;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/CookieSpecBase"));
			global::org.apache.http.impl.cookie.CookieSpecBase_._parse33291 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.CookieSpecBase_._getVersion33292 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.CookieSpecBase_._formatCookies33293 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.CookieSpecBase_._getVersionHeader33294 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
		}
	}
}
