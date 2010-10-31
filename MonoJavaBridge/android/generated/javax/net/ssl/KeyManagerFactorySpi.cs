namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.KeyManagerFactorySpi_))]
	public abstract partial class KeyManagerFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyManagerFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(java.security.KeyStore arg0, char[] arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(javax.net.ssl.ManagerFactoryParameters arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::javax.net.ssl.KeyManager[] engineGetKeyManagers();
		private static global::MonoJavaBridge.MethodId _m3;
		public KeyManagerFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.KeyManagerFactorySpi._m3.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.KeyManagerFactorySpi._m3 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyManagerFactorySpi.staticClass, global::javax.net.ssl.KeyManagerFactorySpi._m3);
			Init(@__env, handle);
		}
		static KeyManagerFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManagerFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManagerFactorySpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.KeyManagerFactorySpi))]
	internal sealed partial class KeyManagerFactorySpi_ : javax.net.ssl.KeyManagerFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyManagerFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(java.security.KeyStore arg0, char[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, "engineInit", "(Ljava/security/KeyStore;[C)V", ref global::javax.net.ssl.KeyManagerFactorySpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(javax.net.ssl.ManagerFactoryParameters arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V", ref global::javax.net.ssl.KeyManagerFactorySpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::javax.net.ssl.KeyManager[] engineGetKeyManagers()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<javax.net.ssl.KeyManager>(this, global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, "engineGetKeyManagers", "()[Ljavax/net/ssl/KeyManager;", ref global::javax.net.ssl.KeyManagerFactorySpi_._m2) as javax.net.ssl.KeyManager[];
		}
		static KeyManagerFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManagerFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManagerFactorySpi"));
		}
	}
}
