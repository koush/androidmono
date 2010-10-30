namespace org.apache.http.impl.auth
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.auth.AuthSchemeBase_))]
	public abstract partial class AuthSchemeBase : java.lang.Object, org.apache.http.auth.AuthScheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AuthSchemeBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getParameter32701;
		public abstract global::java.lang.String getParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getSchemeName32702;
		public abstract global::java.lang.String getSchemeName();
		internal static global::MonoJavaBridge.MethodId _getRealm32703;
		public abstract global::java.lang.String getRealm();
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32704;
		public abstract bool isConnectionBased();
		internal static global::MonoJavaBridge.MethodId _isComplete32705;
		public abstract bool isComplete();
		internal static global::MonoJavaBridge.MethodId _authenticate32706;
		public abstract global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1);
		internal static global::MonoJavaBridge.MethodId _isProxy32707;
		public virtual bool isProxy()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "isProxy", "()Z", ref global::org.apache.http.impl.auth.AuthSchemeBase._isProxy32707);
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge32708;
		public virtual void processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.impl.auth.AuthSchemeBase._processChallenge32708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge32709;
		protected abstract void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _AuthSchemeBase32710;
		public AuthSchemeBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase32710.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase32710 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.auth.AuthSchemeBase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.auth.AuthSchemeBase.staticClass, global::org.apache.http.impl.auth.AuthSchemeBase._AuthSchemeBase32710);
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
		internal static global::MonoJavaBridge.MethodId _getParameter32711;
		public override global::java.lang.String getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._getParameter32711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName32712;
		public override global::java.lang.String getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._getSchemeName32712) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getRealm32713;
		public override global::java.lang.String getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "getRealm", "()Ljava/lang/String;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._getRealm32713) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased32714;
		public override bool isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.impl.auth.AuthSchemeBase_._isConnectionBased32714);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete32715;
		public override bool isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "isComplete", "()Z", ref global::org.apache.http.impl.auth.AuthSchemeBase_._isComplete32715);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate32716;
		public override global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.impl.auth.AuthSchemeBase_._authenticate32716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _parseChallenge32717;
		protected override void parseChallenge(org.apache.http.util.CharArrayBuffer arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.auth.AuthSchemeBase_.staticClass, "parseChallenge", "(Lorg/apache/http/util/CharArrayBuffer;II)V", ref global::org.apache.http.impl.auth.AuthSchemeBase_._parseChallenge32717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
