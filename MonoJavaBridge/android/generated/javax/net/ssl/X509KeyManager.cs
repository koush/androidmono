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
		internal static global::MonoJavaBridge.MethodId _getCertificateChain30154;
		global::java.security.cert.X509Certificate[] javax.net.ssl.X509KeyManager.getCertificateChain(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509KeyManager_._getCertificateChain30154.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509KeyManager_._getCertificateChain30154 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getCertificateChain30154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateKey30155;
		global::java.security.PrivateKey javax.net.ssl.X509KeyManager.getPrivateKey(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509KeyManager_._getPrivateKey30155.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509KeyManager_._getPrivateKey30155 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getPrivateKey30155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _getClientAliases30156;
		global::java.lang.String[] javax.net.ssl.X509KeyManager.getClientAliases(java.lang.String arg0, java.security.Principal[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509KeyManager_._getClientAliases30156.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509KeyManager_._getClientAliases30156 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getClientAliases30156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _chooseClientAlias30157;
		global::java.lang.String javax.net.ssl.X509KeyManager.chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509KeyManager_._chooseClientAlias30157.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509KeyManager_._chooseClientAlias30157 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._chooseClientAlias30157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getServerAliases30158;
		global::java.lang.String[] javax.net.ssl.X509KeyManager.getServerAliases(java.lang.String arg0, java.security.Principal[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509KeyManager_._getServerAliases30158.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509KeyManager_._getServerAliases30158 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getServerAliases30158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _chooseServerAlias30159;
		global::java.lang.String javax.net.ssl.X509KeyManager.chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509KeyManager_._chooseServerAlias30159.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509KeyManager_._chooseServerAlias30159 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._chooseServerAlias30159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		static X509KeyManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509KeyManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509KeyManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
