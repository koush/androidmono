namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2109Spec : org.apache.http.impl.cookie.CookieSpecBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2109Spec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33325;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;", ref global::org.apache.http.impl.cookie.RFC2109Spec._parse33325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.List;
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33326;
		public override int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "getVersion", "()I", ref global::org.apache.http.impl.cookie.RFC2109Spec._getVersion33326);
		}
		internal static global::MonoJavaBridge.MethodId _validate33327;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V", ref global::org.apache.http.impl.cookie.RFC2109Spec._validate33327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33328;
		public override global::java.util.List formatCookies(java.util.List arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;", ref global::org.apache.http.impl.cookie.RFC2109Spec._formatCookies33328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.List;
		}
		public new global::org.apache.http.Header VersionHeader
		{
			get
			{
				return getVersionHeader();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33329;
		public override global::org.apache.http.Header getVersionHeader()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;", ref global::org.apache.http.impl.cookie.RFC2109Spec._getVersionHeader33329) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _formatParamAsVer33330;
		protected virtual void formatParamAsVer(org.apache.http.util.CharArrayBuffer arg0, java.lang.String arg1, java.lang.String arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "formatParamAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Ljava/lang/String;Ljava/lang/String;I)V", ref global::org.apache.http.impl.cookie.RFC2109Spec._formatParamAsVer33330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookieAsVer33331;
		protected virtual void formatCookieAsVer(org.apache.http.util.CharArrayBuffer arg0, org.apache.http.cookie.Cookie arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "formatCookieAsVer", "(Lorg/apache/http/util/CharArrayBuffer;Lorg/apache/http/cookie/Cookie;I)V", ref global::org.apache.http.impl.cookie.RFC2109Spec._formatCookieAsVer33331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2109Spec33332;
		public RFC2109Spec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109Spec._RFC2109Spec33332.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109Spec._RFC2109Spec33332 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2109Spec.staticClass, global::org.apache.http.impl.cookie.RFC2109Spec._RFC2109Spec33332);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RFC2109Spec33333;
		public RFC2109Spec(java.lang.String[] arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109Spec._RFC2109Spec33333.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109Spec._RFC2109Spec33333 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109Spec.staticClass, "<init>", "([Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2109Spec.staticClass, global::org.apache.http.impl.cookie.RFC2109Spec._RFC2109Spec33333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RFC2109Spec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2109Spec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2109Spec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
