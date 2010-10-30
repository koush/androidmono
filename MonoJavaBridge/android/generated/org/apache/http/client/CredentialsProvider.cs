namespace org.apache.http.client
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.client.CredentialsProvider_))]
	public partial interface CredentialsProvider  : global::MonoJavaBridge.IJavaObject 
	{
		void clear();
		global::org.apache.http.auth.Credentials getCredentials(org.apache.http.auth.AuthScope arg0);
		void setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.CredentialsProvider))]
	internal sealed partial class CredentialsProvider_ : java.lang.Object, CredentialsProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CredentialsProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clear31878;
		void org.apache.http.client.CredentialsProvider.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.CredentialsProvider_.staticClass, "clear", "()V", ref global::org.apache.http.client.CredentialsProvider_._clear31878);
		}
		internal static global::MonoJavaBridge.MethodId _getCredentials31879;
		global::org.apache.http.auth.Credentials org.apache.http.client.CredentialsProvider.getCredentials(org.apache.http.auth.AuthScope arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.auth.Credentials>(this, global::org.apache.http.client.CredentialsProvider_.staticClass, "getCredentials", "(Lorg/apache/http/auth/AuthScope;)Lorg/apache/http/auth/Credentials;", ref global::org.apache.http.client.CredentialsProvider_._getCredentials31879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.auth.Credentials;
		}
		internal static global::MonoJavaBridge.MethodId _setCredentials31880;
		void org.apache.http.client.CredentialsProvider.setCredentials(org.apache.http.auth.AuthScope arg0, org.apache.http.auth.Credentials arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.CredentialsProvider_.staticClass, "setCredentials", "(Lorg/apache/http/auth/AuthScope;Lorg/apache/http/auth/Credentials;)V", ref global::org.apache.http.client.CredentialsProvider_._setCredentials31880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static CredentialsProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.CredentialsProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/CredentialsProvider"));
		}
		internal static void InitJNI()
		{
		}
	}
}
