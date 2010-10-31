namespace org.apache.http.auth
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.auth.AuthScheme_))]
	public partial interface AuthScheme  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getParameter(java.lang.String arg0);
		global::java.lang.String getSchemeName();
		void processChallenge(org.apache.http.Header arg0);
		global::java.lang.String getRealm();
		bool isConnectionBased();
		bool isComplete();
		global::org.apache.http.Header authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.auth.AuthScheme))]
	internal sealed partial class AuthScheme_ : java.lang.Object, AuthScheme
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthScheme_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.String org.apache.http.auth.AuthScheme.getParameter(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScheme_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;", ref global::org.apache.http.auth.AuthScheme_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String org.apache.http.auth.AuthScheme.getSchemeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScheme_.staticClass, "getSchemeName", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthScheme_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void org.apache.http.auth.AuthScheme.processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.auth.AuthScheme_.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V", ref global::org.apache.http.auth.AuthScheme_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String org.apache.http.auth.AuthScheme.getRealm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.auth.AuthScheme_.staticClass, "getRealm", "()Ljava/lang/String;", ref global::org.apache.http.auth.AuthScheme_._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool org.apache.http.auth.AuthScheme.isConnectionBased()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.AuthScheme_.staticClass, "isConnectionBased", "()Z", ref global::org.apache.http.auth.AuthScheme_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool org.apache.http.auth.AuthScheme.isComplete()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.auth.AuthScheme_.staticClass, "isComplete", "()Z", ref global::org.apache.http.auth.AuthScheme_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		global::org.apache.http.Header org.apache.http.auth.AuthScheme.authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.Header>(this, global::org.apache.http.auth.AuthScheme_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;", ref global::org.apache.http.auth.AuthScheme_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.apache.http.Header;
		}
		static AuthScheme_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScheme_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScheme"));
		}
	}
}
