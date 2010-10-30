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
		internal static global::MonoJavaBridge.MethodId _getParameter31777;
		global::java.lang.String org.apache.http.auth.AuthScheme.getParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._getParameter31777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getSchemeName31778;
		global::java.lang.String org.apache.http.auth.AuthScheme.getSchemeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._getSchemeName31778)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _processChallenge31779;
		void org.apache.http.auth.AuthScheme.processChallenge(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._processChallenge31779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getRealm31780;
		global::java.lang.String org.apache.http.auth.AuthScheme.getRealm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._getRealm31780)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectionBased31781;
		bool org.apache.http.auth.AuthScheme.isConnectionBased()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._isConnectionBased31781);
		}
		internal static global::MonoJavaBridge.MethodId _isComplete31782;
		bool org.apache.http.auth.AuthScheme.isComplete()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._isComplete31782);
		}
		internal static global::MonoJavaBridge.MethodId _authenticate31783;
		global::org.apache.http.Header org.apache.http.auth.AuthScheme.authenticate(org.apache.http.auth.Credentials arg0, org.apache.http.HttpRequest arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.auth.AuthScheme_._authenticate31783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as org.apache.http.Header;
		}
		static AuthScheme_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.auth.AuthScheme_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/auth/AuthScheme"));
			global::org.apache.http.auth.AuthScheme_._getParameter31777 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "getParameter", "(Ljava/lang/String;)Ljava/lang/String;");
			global::org.apache.http.auth.AuthScheme_._getSchemeName31778 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "getSchemeName", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScheme_._processChallenge31779 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "processChallenge", "(Lorg/apache/http/Header;)V");
			global::org.apache.http.auth.AuthScheme_._getRealm31780 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "getRealm", "()Ljava/lang/String;");
			global::org.apache.http.auth.AuthScheme_._isConnectionBased31781 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "isConnectionBased", "()Z");
			global::org.apache.http.auth.AuthScheme_._isComplete31782 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "isComplete", "()Z");
			global::org.apache.http.auth.AuthScheme_._authenticate31783 = @__env.GetMethodIDNoThrow(global::org.apache.http.auth.AuthScheme_.staticClass, "authenticate", "(Lorg/apache/http/auth/Credentials;Lorg/apache/http/HttpRequest;)Lorg/apache/http/Header;");
		}
		internal static void InitJNI()
		{
		}
	}
}
