namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.X509ExtendedKeyManager_))]
	public abstract partial class X509ExtendedKeyManager : java.lang.Object, X509KeyManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected X509ExtendedKeyManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateChain30139;
		public abstract global::java.security.cert.X509Certificate[] getCertificateChain(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getPrivateKey30140;
		public abstract global::java.security.PrivateKey getPrivateKey(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _getClientAliases30141;
		public abstract global::java.lang.String[] getClientAliases(java.lang.String arg0, java.security.Principal[] arg1);
		internal static global::MonoJavaBridge.MethodId _chooseClientAlias30142;
		public abstract global::java.lang.String chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2);
		internal static global::MonoJavaBridge.MethodId _getServerAliases30143;
		public abstract global::java.lang.String[] getServerAliases(java.lang.String arg0, java.security.Principal[] arg1);
		internal static global::MonoJavaBridge.MethodId _chooseServerAlias30144;
		public abstract global::java.lang.String chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2);
		internal static global::MonoJavaBridge.MethodId _chooseEngineClientAlias30145;
		public virtual global::java.lang.String chooseEngineClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, javax.net.ssl.SSLEngine arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509ExtendedKeyManager.staticClass, "chooseEngineClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang/String;", ref global::javax.net.ssl.X509ExtendedKeyManager._chooseEngineClientAlias30145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _chooseEngineServerAlias30146;
		public virtual global::java.lang.String chooseEngineServerAlias(java.lang.String arg0, java.security.Principal[] arg1, javax.net.ssl.SSLEngine arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509ExtendedKeyManager.staticClass, "chooseEngineServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljavax/net/ssl/SSLEngine;)Ljava/lang/String;", ref global::javax.net.ssl.X509ExtendedKeyManager._chooseEngineServerAlias30146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _X509ExtendedKeyManager30147;
		protected X509ExtendedKeyManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509ExtendedKeyManager._X509ExtendedKeyManager30147.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509ExtendedKeyManager._X509ExtendedKeyManager30147 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509ExtendedKeyManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.X509ExtendedKeyManager.staticClass, global::javax.net.ssl.X509ExtendedKeyManager._X509ExtendedKeyManager30147);
			Init(@__env, handle);
		}
		static X509ExtendedKeyManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509ExtendedKeyManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509ExtendedKeyManager"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.X509ExtendedKeyManager))]
	internal sealed partial class X509ExtendedKeyManager_ : javax.net.ssl.X509ExtendedKeyManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509ExtendedKeyManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getCertificateChain30148;
		public override global::java.security.cert.X509Certificate[] getCertificateChain(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.security.cert.X509Certificate>(this, global::javax.net.ssl.X509ExtendedKeyManager_.staticClass, "getCertificateChain", "(Ljava/lang/String;)[Ljava/security/cert/X509Certificate;", ref global::javax.net.ssl.X509ExtendedKeyManager_._getCertificateChain30148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.X509Certificate[];
		}
		internal static global::MonoJavaBridge.MethodId _getPrivateKey30149;
		public override global::java.security.PrivateKey getPrivateKey(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::javax.net.ssl.X509ExtendedKeyManager_.staticClass, "getPrivateKey", "(Ljava/lang/String;)Ljava/security/PrivateKey;", ref global::javax.net.ssl.X509ExtendedKeyManager_._getPrivateKey30149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _getClientAliases30150;
		public override global::java.lang.String[] getClientAliases(java.lang.String arg0, java.security.Principal[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509ExtendedKeyManager_.staticClass, "getClientAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", ref global::javax.net.ssl.X509ExtendedKeyManager_._getClientAliases30150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _chooseClientAlias30151;
		public override global::java.lang.String chooseClientAlias(java.lang.String[] arg0, java.security.Principal[] arg1, java.net.Socket arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509ExtendedKeyManager_.staticClass, "chooseClientAlias", "([Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", ref global::javax.net.ssl.X509ExtendedKeyManager_._chooseClientAlias30151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getServerAliases30152;
		public override global::java.lang.String[] getServerAliases(java.lang.String arg0, java.security.Principal[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509ExtendedKeyManager_.staticClass, "getServerAliases", "(Ljava/lang/String;[Ljava/security/Principal;)[Ljava/lang/String;", ref global::javax.net.ssl.X509ExtendedKeyManager_._getServerAliases30152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _chooseServerAlias30153;
		public override global::java.lang.String chooseServerAlias(java.lang.String arg0, java.security.Principal[] arg1, java.net.Socket arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.X509ExtendedKeyManager_.staticClass, "chooseServerAlias", "(Ljava/lang/String;[Ljava/security/Principal;Ljava/net/Socket;)Ljava/lang/String;", ref global::javax.net.ssl.X509ExtendedKeyManager_._chooseServerAlias30153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		static X509ExtendedKeyManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509ExtendedKeyManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509ExtendedKeyManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
