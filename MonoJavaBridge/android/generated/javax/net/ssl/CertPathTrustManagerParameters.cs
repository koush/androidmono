namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathTrustManagerParameters : java.lang.Object, ManagerFactoryParameters
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.security.cert.CertPathParameters getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertPathParameters>(this, global::javax.net.ssl.CertPathTrustManagerParameters.staticClass, "getParameters", "()Ljava/security/cert/CertPathParameters;", ref global::javax.net.ssl.CertPathTrustManagerParameters._m0) as java.security.cert.CertPathParameters;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CertPathTrustManagerParameters(java.security.cert.CertPathParameters arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.CertPathTrustManagerParameters._m1.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.CertPathTrustManagerParameters._m1 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.CertPathTrustManagerParameters.staticClass, "<init>", "(Ljava/security/cert/CertPathParameters;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.CertPathTrustManagerParameters.staticClass, global::javax.net.ssl.CertPathTrustManagerParameters._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CertPathTrustManagerParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.CertPathTrustManagerParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/CertPathTrustManagerParameters"));
		}
		internal static void InitJNI()
		{
		}
	}
}
