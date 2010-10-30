namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.net.ssl.X509TrustManager_))]
	public partial interface X509TrustManager : TrustManager
	{
		void checkClientTrusted(java.security.cert.X509Certificate[] arg0, java.lang.String arg1);
		void checkServerTrusted(java.security.cert.X509Certificate[] arg0, java.lang.String arg1);
		global::java.security.cert.X509Certificate[] getAcceptedIssuers();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.X509TrustManager))]
	internal sealed partial class X509TrustManager_ : java.lang.Object, X509TrustManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal X509TrustManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkClientTrusted30160;
		void javax.net.ssl.X509TrustManager.checkClientTrusted(java.security.cert.X509Certificate[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509TrustManager_._checkClientTrusted30160.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509TrustManager_._checkClientTrusted30160 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509TrustManager_.staticClass, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_._checkClientTrusted30160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkServerTrusted30161;
		void javax.net.ssl.X509TrustManager.checkServerTrusted(java.security.cert.X509Certificate[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509TrustManager_._checkServerTrusted30161.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509TrustManager_._checkServerTrusted30161 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509TrustManager_.staticClass, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_._checkServerTrusted30161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedIssuers30162;
		global::java.security.cert.X509Certificate[] javax.net.ssl.X509TrustManager.getAcceptedIssuers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.X509TrustManager_._getAcceptedIssuers30162.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.X509TrustManager_._getAcceptedIssuers30162 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509TrustManager_.staticClass, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_._getAcceptedIssuers30162)) as java.security.cert.X509Certificate[];
		}
		static X509TrustManager_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509TrustManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509TrustManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
