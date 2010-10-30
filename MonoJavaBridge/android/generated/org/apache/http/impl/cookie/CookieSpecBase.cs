namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.cookie.CookieSpecBase_))]
	public abstract partial class CookieSpecBase : org.apache.http.impl.cookie.AbstractCookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CookieSpecBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultDomain33286;
		protected static global::java.lang.String getDefaultDomain(org.apache.http.cookie.CookieOrigin arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultDomain33286.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultDomain33286 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "getDefaultDomain", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultDomain33286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parse33287;
		protected virtual global::java.util.List parse(org.apache.http.HeaderElement[] arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase._parse33287.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase._parse33287 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "parse", "([Lorg/apache/http/HeaderElement;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._parse33287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match33288;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase._match33288.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase._match33288 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._match33288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33289;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase._validate33289.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase._validate33289 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._validate33289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultPath33290;
		protected static global::java.lang.String getDefaultPath(org.apache.http.cookie.CookieOrigin arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultPath33290.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultPath33290 = @__env.GetStaticMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "getDefaultPath", "(Lorg/apache/http/cookie/CookieOrigin;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._getDefaultPath33290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CookieSpecBase33291;
		public CookieSpecBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase._CookieSpecBase33291.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase._CookieSpecBase33291 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.CookieSpecBase.staticClass, global::org.apache.http.impl.cookie.CookieSpecBase._CookieSpecBase33291);
			Init(@__env, handle);
		}
		static CookieSpecBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.CookieSpecBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/CookieSpecBase"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.cookie.CookieSpecBase))]
	internal sealed partial class CookieSpecBase_ : org.apache.http.impl.cookie.CookieSpecBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieSpecBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33292;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase_._parse33292.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase_._parse33292 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._parse33292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33293;
		public override int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase_._getVersion33293.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase_._getVersion33293 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "getVersion", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._getVersion33293);
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33294;
		public override global::java.util.List formatCookies(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase_._formatCookies33294.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase_._formatCookies33294 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._formatCookies33294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33295;
		public override global::org.apache.http.Header getVersionHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.CookieSpecBase_._getVersionHeader33295.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.CookieSpecBase_._getVersionHeader33295 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.CookieSpecBase_._getVersionHeader33295)) as org.apache.http.Header;
		}
		static CookieSpecBase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.CookieSpecBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/CookieSpecBase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
