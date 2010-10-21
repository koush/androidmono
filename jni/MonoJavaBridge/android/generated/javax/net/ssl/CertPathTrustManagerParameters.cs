namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathTrustManagerParameters : java.lang.Object, ManagerFactoryParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathTrustManagerParameters()
		{
			InitJNI();
		}
		protected CertPathTrustManagerParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.security.cert.CertPathParameters Parameters
		{
			get
			{
				return getParameters();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters29710;
		public virtual global::java.security.cert.CertPathParameters getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathParameters>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.CertPathTrustManagerParameters._getParameters29710)) as java.security.cert.CertPathParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathParameters>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.CertPathTrustManagerParameters.staticClass, global::javax.net.ssl.CertPathTrustManagerParameters._getParameters29710)) as java.security.cert.CertPathParameters;
		}
		internal static global::MonoJavaBridge.MethodId _CertPathTrustManagerParameters29711;
		public CertPathTrustManagerParameters(java.security.cert.CertPathParameters arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.CertPathTrustManagerParameters.staticClass, global::javax.net.ssl.CertPathTrustManagerParameters._CertPathTrustManagerParameters29711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.CertPathTrustManagerParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/CertPathTrustManagerParameters"));
			global::javax.net.ssl.CertPathTrustManagerParameters._getParameters29710 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.CertPathTrustManagerParameters.staticClass, "getParameters", "()Ljava/security/cert/CertPathParameters;");
			global::javax.net.ssl.CertPathTrustManagerParameters._CertPathTrustManagerParameters29711 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.CertPathTrustManagerParameters.staticClass, "<init>", "(Ljava/security/cert/CertPathParameters;)V");
		}
	}
}
