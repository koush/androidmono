namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.X509KeyManager_))]
	public interface X509KeyManager : KeyManager
	{
		global::java.security.cert.X509Certificate[] getCertificateChain(java.lang.String arg0);
		global::java.security.PrivateKey getPrivateKey(java.lang.String arg0);
		global::java.lang.String[] getClientAliases(java.lang.String arg0, java.security.Principal[] arg1);
		global::java.lang.String chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2);
		global::java.lang.String[] getServerAliases(java.lang.String arg0, java.security.Principal[] arg1);
		global::java.lang.String chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.X509KeyManager))]
	public sealed partial class X509KeyManager_ : java.lang.Object, X509KeyManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509KeyManager_()
		{
			InitJNI();
		}
		internal X509KeyManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateChain30035;
		 global::java.security.cert.X509Certificate[] javax.net.ssl.X509KeyManager.getCertificateChain(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getCertificateChain30035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.X509Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_.staticClass, global::javax.net.ssl.X509KeyManager_._getCertificateChain30035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateKey30036;
		 global::java.security.PrivateKey javax.net.ssl.X509KeyManager.getPrivateKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getPrivateKey30036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.PrivateKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_.staticClass, global::javax.net.ssl.X509KeyManager_._getPrivateKey30036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _getClientAliases30037;
		 global::java.lang.String[] javax.net.ssl.X509KeyManager.getClientAliases(java.lang.String arg0, java.security.Principal[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getClientAliases30037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_.staticClass, global::javax.net.ssl.X509KeyManager_._getClientAliases30037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _chooseClientAlias30038;
		 global::java.lang.String javax.net.ssl.X509KeyManager.chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._chooseClientAlias30038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_.staticClass, global::javax.net.ssl.X509KeyManager_._chooseClientAlias30038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getServerAliases30039;
		 global::java.lang.String[] javax.net.ssl.X509KeyManager.getServerAliases(java.lang.String arg0, java.security.Principal[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._getServerAliases30039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_.staticClass, global::javax.net.ssl.X509KeyManager_._getServerAliases30039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _chooseServerAlias30040;
		 global::java.lang.String javax.net.ssl.X509KeyManager.chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_._chooseServerAlias30040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509KeyManager_.staticClass, global::javax.net.ssl.X509KeyManager_._chooseServerAlias30040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509KeyManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509KeyManager"));
			global::javax.net.ssl.X509KeyManager_._getCertificateChain30035 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;");
			global::javax.net.ssl.X509KeyManager_._getPrivateKey30036 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;");
			global::javax.net.ssl.X509KeyManager_._getClientAliases30037 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;");
			global::javax.net.ssl.X509KeyManager_._chooseClientAlias30038 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;");
			global::javax.net.ssl.X509KeyManager_._getServerAliases30039 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;");
			global::javax.net.ssl.X509KeyManager_._chooseServerAlias30040 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509KeyManager_.staticClass, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;");
		}
	}
}
