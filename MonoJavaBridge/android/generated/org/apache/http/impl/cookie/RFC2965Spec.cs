namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965Spec : org.apache.http.impl.cookie.RFC2109Spec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2965Spec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33356;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._parse33356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match33357;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._match33357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33358;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._getVersion33358);
		}
		internal static global::MonoJavaBridge.MethodId _validate33359;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._validate33359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33360;
		public override global::org.apache.http.Header getVersionHeader()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._getVersionHeader33360)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _formatCookieAsVer33361;
		protected override void formatCookieAsVer(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.cookie.Cookie arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._formatCookieAsVer33361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965Spec33362;
		public RFC2965Spec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec33362);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965Spec33363;
		public RFC2965Spec(java.lang.String[] arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965Spec.staticClass, global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec33363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RFC2965Spec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965Spec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965Spec"));
			global::org.apache.http.impl.cookie.RFC2965Spec._parse33356 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			global::org.apache.http.impl.cookie.RFC2965Spec._match33357 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			global::org.apache.http.impl.cookie.RFC2965Spec._getVersion33358 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "getVersion", "()I");
			global::org.apache.http.impl.cookie.RFC2965Spec._validate33359 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::org.apache.http.impl.cookie.RFC2965Spec._getVersionHeader33360 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			global::org.apache.http.impl.cookie.RFC2965Spec._formatCookieAsVer33361 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V");
			global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec33362 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "<init>", "()V");
			global::org.apache.http.impl.cookie.RFC2965Spec._RFC2965Spec33363 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965Spec.staticClass, "<init>", "([Ljava/lang/String;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
