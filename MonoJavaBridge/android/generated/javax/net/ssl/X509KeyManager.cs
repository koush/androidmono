namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.X509KeyManager_))]
	public partial interface X509KeyManager : KeyManager
	{
		global::java.security.cert.X509Certificate[] getCertificateChain(java.lang.String arg0);
		global::java.security.PrivateKey getPrivateKey(java.lang.String arg0);
		global::java.lang.String[] getClientAliases(java.lang.String arg0, java.security.Principal[] arg1);
		global::java.lang.String chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2);
		global::java.lang.String[] getServerAliases(java.lang.String arg0, java.security.Principal[] arg1);
		global::java.lang.String chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.X509KeyManager))]
	internal sealed partial class X509KeyManager_ : java.lang.Object, X509KeyManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509KeyManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.security.cert.X509Certificate[] javax.net.ssl.X509KeyManager.getCertificateChain(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.X509Certificate>(this, global::javax.net.ssl.X509KeyManager_.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", ref global::javax.net.ssl.X509KeyManager_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.X509Certificate[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.security.PrivateKey javax.net.ssl.X509KeyManager.getPrivateKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::javax.net.ssl.X509KeyManager_.staticClass, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", ref global::javax.net.ssl.X509KeyManager_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PrivateKey;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.String[] javax.net.ssl.X509KeyManager.getClientAliases(java.lang.String arg0, java.security.Principal[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509KeyManager_.staticClass, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", ref global::javax.net.ssl.X509KeyManager_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.String javax.net.ssl.X509KeyManager.chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509KeyManager_.staticClass, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", ref global::javax.net.ssl.X509KeyManager_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.String[] javax.net.ssl.X509KeyManager.getServerAliases(java.lang.String arg0, java.security.Principal[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509KeyManager_.staticClass, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", ref global::javax.net.ssl.X509KeyManager_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		global::java.lang.String javax.net.ssl.X509KeyManager.chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509KeyManager_.staticClass, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", ref global::javax.net.ssl.X509KeyManager_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		static X509KeyManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509KeyManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509KeyManager"));
		}
	}
}
