namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.TrustManagerFactorySpi_))]
	public abstract partial class TrustManagerFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TrustManagerFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(java.security.KeyStore arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(javax.net.ssl.ManagerFactoryParameters arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::javax.net.ssl.TrustManager[] engineGetTrustManagers();
		private static global::MonoJavaBridge.MethodId _m3;
		public TrustManagerFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.TrustManagerFactorySpi._m3.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.TrustManagerFactorySpi._m3 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.TrustManagerFactorySpi.staticClass, global::javax.net.ssl.TrustManagerFactorySpi._m3);
			Init(@__env, handle);
		}
		static TrustManagerFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactorySpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.TrustManagerFactorySpi))]
	internal sealed partial class TrustManagerFactorySpi_ : javax.net.ssl.TrustManagerFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TrustManagerFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(java.security.KeyStore arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, "engineInit", "(Ljava/security/KeyStore;)V", ref global::javax.net.ssl.TrustManagerFactorySpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(javax.net.ssl.ManagerFactoryParameters arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", ref global::javax.net.ssl.TrustManagerFactorySpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::javax.net.ssl.TrustManager[] engineGetTrustManagers()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.net.ssl.TrustManager>(this, global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, "engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;", ref global::javax.net.ssl.TrustManagerFactorySpi_._m2) as javax.net.ssl.TrustManager[];
		}
		static TrustManagerFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactorySpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
