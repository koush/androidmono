namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.auth.AuthSchemeBase_))]
	public abstract partial class AuthSchemeBase : java.lang.Object, org.apache.http.auth.AuthScheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthSchemeBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.String getParameter(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.String getSchemeName();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.lang.String getRealm();
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract bool isConnectionBased();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool isComplete();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isProxy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isProxy", "()Z", ref global::org.apache.http.impl.auth.AuthSchemeBase._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.impl.auth.AuthSchemeBase._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected abstract void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m9;
		public AuthSchemeBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.AuthSchemeBase._m9.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.AuthSchemeBase._m9 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._m9);
			Init(@__env, handle);
		}
		static AuthSchemeBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.AuthSchemeBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/AuthSchemeBase"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.auth.AuthSchemeBase))]
	internal sealed partial class AuthSchemeBase_ : org.apache.http.impl.auth.AuthSchemeBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthSchemeBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getRealm", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isComplete", "()Z", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.impl.auth.AuthSchemeBase_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		static AuthSchemeBase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/auth/AuthSchemeBase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
