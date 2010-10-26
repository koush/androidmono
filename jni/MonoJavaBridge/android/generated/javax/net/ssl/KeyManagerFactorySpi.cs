namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.net.ssl.KeyManagerFactorySpi_))]
	public abstract partial class KeyManagerFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyManagerFactorySpi()
		{
			InitJNI();
		}
		protected KeyManagerFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit29871;
		protected abstract void engineInit(java.security.KeyStore arg0, char[] arg1);
		internal static global::MonoJavaBridge.MethodId _engineInit29872;
		protected abstract void engineInit(javax.net.ssl.ManagerFactoryParameters arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetKeyManagers29873;
		protected abstract global::javax.net.ssl.KeyManager[] engineGetKeyManagers();
		internal static global::MonoJavaBridge.MethodId _KeyManagerFactorySpi29874;
		public KeyManagerFactorySpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.KeyManagerFactorySpi.staticClass, global::javax.net.ssl.KeyManagerFactorySpi._KeyManagerFactorySpi29874);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManagerFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManagerFactorySpi"));
			global::javax.net.ssl.KeyManagerFactorySpi._engineInit29871 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi.staticClass, "engineInit", "(Ljava/security/KeyStore;[C)V");
			global::javax.net.ssl.KeyManagerFactorySpi._engineInit29872 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi.staticClass, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.KeyManagerFactorySpi._engineGetKeyManagers29873 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi.staticClass, "engineGetKeyManagers", "()[Ljavax/net/ssl/KeyManager;");
			global::javax.net.ssl.KeyManagerFactorySpi._KeyManagerFactorySpi29874 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.net.ssl.KeyManagerFactorySpi))]
	internal sealed partial class KeyManagerFactorySpi_ : javax.net.ssl.KeyManagerFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyManagerFactorySpi_()
		{
			InitJNI();
		}
		internal KeyManagerFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit29875;
		protected override void engineInit(java.security.KeyStore arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactorySpi_._engineInit29875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, global::javax.net.ssl.KeyManagerFactorySpi_._engineInit29875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit29876;
		protected override void engineInit(javax.net.ssl.ManagerFactoryParameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactorySpi_._engineInit29876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, global::javax.net.ssl.KeyManagerFactorySpi_._engineInit29876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeyManagers29877;
		protected override global::javax.net.ssl.KeyManager[] engineGetKeyManagers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.KeyManager>(@__env.CallObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactorySpi_._engineGetKeyManagers29877)) as javax.net.ssl.KeyManager[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.KeyManager>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, global::javax.net.ssl.KeyManagerFactorySpi_._engineGetKeyManagers29877)) as javax.net.ssl.KeyManager[];
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.KeyManagerFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/KeyManagerFactorySpi"));
			global::javax.net.ssl.KeyManagerFactorySpi_._engineInit29875 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, "engineInit", "(Ljava/security/KeyStore;[C)V");
			global::javax.net.ssl.KeyManagerFactorySpi_._engineInit29876 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, "engineInit", "(Ljavax/net/ssl/ManagerFactoryParameters;)V");
			global::javax.net.ssl.KeyManagerFactorySpi_._engineGetKeyManagers29877 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.KeyManagerFactorySpi_.staticClass, "engineGetKeyManagers", "()[Ljavax/net/ssl/KeyManager;");
		}
	}
}
