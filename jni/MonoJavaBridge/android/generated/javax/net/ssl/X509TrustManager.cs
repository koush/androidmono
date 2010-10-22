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
	public sealed partial class X509TrustManager_ : java.lang.Object, X509TrustManager
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static X509TrustManager_()
		{
			InitJNI();
		}
		internal X509TrustManager_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _checkClientTrusted30041;
		 void javax.net.ssl.X509TrustManager.checkClientTrusted(java.security.cert.X509Certificate[] arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_._checkClientTrusted30041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_.staticClass, global::javax.net.ssl.X509TrustManager_._checkClientTrusted30041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _checkServerTrusted30042;
		 void javax.net.ssl.X509TrustManager.checkServerTrusted(java.security.cert.X509Certificate[] arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_._checkServerTrusted30042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_.staticClass, global::javax.net.ssl.X509TrustManager_._checkServerTrusted30042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAcceptedIssuers30043;
		 global::java.security.cert.X509Certificate[] javax.net.ssl.X509TrustManager.getAcceptedIssuers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.X509Certificate>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_._getAcceptedIssuers30043)) as java.security.cert.X509Certificate[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.cert.X509Certificate>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.X509TrustManager_.staticClass, global::javax.net.ssl.X509TrustManager_._getAcceptedIssuers30043)) as java.security.cert.X509Certificate[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.X509TrustManager_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/X509TrustManager"));
			global::javax.net.ssl.X509TrustManager_._checkClientTrusted30041 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509TrustManager_.staticClass, "checkClientTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			global::javax.net.ssl.X509TrustManager_._checkServerTrusted30042 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509TrustManager_.staticClass, "checkServerTrusted", "([Ljava/security/cert/X509Certificate;Ljava/lang/String;)V");
			global::javax.net.ssl.X509TrustManager_._getAcceptedIssuers30043 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.X509TrustManager_.staticClass, "getAcceptedIssuers", "()[Ljava/security/cert/X509Certificate;");
		}
	}
}
