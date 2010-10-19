namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.TrustManagerFactorySpi_))]
	public abstract partial class TrustManagerFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TrustManagerFactorySpi()
		{
			InitJNI();
		}
		protected TrustManagerFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit23582;
		protected abstract void engineInit(java.security.KeyStore arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit23583;
		protected abstract void engineInit(javax.net.ssl.ManagerFactoryParameters arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetTrustManagers23584;
		protected abstract global::javax.net.ssl.TrustManager[] engineGetTrustManagers();
		internal static global::MonoJavaBridge.MethodId _TrustManagerFactorySpi23585;
		public TrustManagerFactorySpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.TrustManagerFactorySpi.staticClass, global::javax.net.ssl.TrustManagerFactorySpi._TrustManagerFactorySpi23585);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactorySpi"));
			global::javax.net.ssl.TrustManagerFactorySpi._engineInit23582 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi.staticClass, "engineInit", "(Ljava/security/KeyStore;)V");
			global::javax.net.ssl.TrustManagerFactorySpi._engineInit23583 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi.staticClass, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.TrustManagerFactorySpi._engineGetTrustManagers23584 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi.staticClass, "engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;");
			global::javax.net.ssl.TrustManagerFactorySpi._TrustManagerFactorySpi23585 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.TrustManagerFactorySpi))]
	public sealed partial class TrustManagerFactorySpi_ : javax.net.ssl.TrustManagerFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TrustManagerFactorySpi_()
		{
			InitJNI();
		}
		internal TrustManagerFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit23586;
		protected override void engineInit(java.security.KeyStore arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactorySpi_._engineInit23586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, global::javax.net.ssl.TrustManagerFactorySpi_._engineInit23586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit23587;
		protected override void engineInit(javax.net.ssl.ManagerFactoryParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactorySpi_._engineInit23587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, global::javax.net.ssl.TrustManagerFactorySpi_._engineInit23587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetTrustManagers23588;
		protected override global::javax.net.ssl.TrustManager[] engineGetTrustManagers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactorySpi_._engineGetTrustManagers23588)) as javax.net.ssl.TrustManager[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.TrustManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, global::javax.net.ssl.TrustManagerFactorySpi_._engineGetTrustManagers23588)) as javax.net.ssl.TrustManager[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.TrustManagerFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/TrustManagerFactorySpi"));
			global::javax.net.ssl.TrustManagerFactorySpi_._engineInit23586 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, "engineInit", "(Ljava/security/KeyStore;)V");
			global::javax.net.ssl.TrustManagerFactorySpi_._engineInit23587 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.TrustManagerFactorySpi_._engineGetTrustManagers23588 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.TrustManagerFactorySpi_.staticClass, "engineGetTrustManagers", "()[Ljavax/net/ssl/TrustManager;");
		}
	}
}
