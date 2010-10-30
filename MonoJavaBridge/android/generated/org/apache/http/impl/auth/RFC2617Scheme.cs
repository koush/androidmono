namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.auth.RFC2617Scheme_))]
	public abstract partial class RFC2617Scheme : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2617Scheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameters32750;
		protected virtual global::java.util.Map getParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme._getParameters32750.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme._getParameters32750 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getParameters", "()Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._getParameters32750) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _getParameter32751;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme._getParameter32751.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme._getParameter32751 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._getParameter32751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRealm32752;
		public override global::java.lang.String getRealm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme._getRealm32752.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme._getRealm32752 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getRealm", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._getRealm32752) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge32753;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme._parseChallenge32753.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme._parseChallenge32753 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._parseChallenge32753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2617Scheme32754;
		public RFC2617Scheme() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme._RFC2617Scheme32754.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme._RFC2617Scheme32754 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._RFC2617Scheme32754);
			Init(@__env, handle);
		}
		static RFC2617Scheme()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.RFC2617Scheme.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/RFC2617Scheme"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.RFC2617Scheme))]
	internal sealed partial class RFC2617Scheme_ : org.apache.http.impl.auth.RFC2617Scheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RFC2617Scheme_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32755;
		public override global::java.lang.String getSchemeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme_._getSchemeName32755.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme_._getSchemeName32755 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "getSchemeName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._getSchemeName32755)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32756;
		public override bool isConnectionBased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme_._isConnectionBased32756.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme_._isConnectionBased32756 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "isConnectionBased", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._isConnectionBased32756);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32757;
		public override bool isComplete()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme_._isComplete32757.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme_._isComplete32757 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "isComplete", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._isComplete32757);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32758;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme_._authenticate32758.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme_._authenticate32758 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.auth.RFC2617Scheme_._authenticate32758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		static RFC2617Scheme_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/RFC2617Scheme"));
		}
		internal static void InitJNI()
		{
		}
	}
}
