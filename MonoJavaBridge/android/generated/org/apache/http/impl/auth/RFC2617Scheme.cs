namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.auth.RFC2617Scheme_))]
	public abstract partial class RFC2617Scheme : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2617Scheme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::java.util.Map getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getParameters", "()Ljava/util/Map;", ref global::org.apache.http.impl.auth.RFC2617Scheme._m0) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.auth.RFC2617Scheme._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "getRealm", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.RFC2617Scheme._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.impl.auth.RFC2617Scheme._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public RFC2617Scheme() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.RFC2617Scheme._m4.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.RFC2617Scheme._m4 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.RFC2617Scheme.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.RFC2617Scheme.staticClass, global::org.apache.http.impl.auth.RFC2617Scheme._m4);
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
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.RFC2617Scheme_._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.impl.auth.RFC2617Scheme_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "isComplete", "()Z", ref global::org.apache.http.impl.auth.RFC2617Scheme_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.auth.RFC2617Scheme_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.impl.auth.RFC2617Scheme_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
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
