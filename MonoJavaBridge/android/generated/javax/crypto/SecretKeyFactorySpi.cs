namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.SecretKeyFactorySpi_))]
	public abstract partial class SecretKeyFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecretKeyFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract global::java.security.spec.KeySpec engineGetKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract global::javax.crypto.SecretKey engineTranslateKey(javax.crypto.SecretKey arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::javax.crypto.SecretKey engineGenerateSecret(java.security.spec.KeySpec arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public SecretKeyFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactorySpi._m3.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactorySpi._m3 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SecretKeyFactorySpi.staticClass, global::javax.crypto.SecretKeyFactorySpi._m3);
			Init(@__env, handle);
		}
		static SecretKeyFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactorySpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.SecretKeyFactorySpi))]
	internal sealed partial class SecretKeyFactorySpi_ : javax.crypto.SecretKeyFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecretKeyFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.security.spec.KeySpec engineGetKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.KeySpec>(this, global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", ref global::javax.crypto.SecretKeyFactorySpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.KeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::javax.crypto.SecretKey engineTranslateKey(javax.crypto.SecretKey arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.SecretKeyFactorySpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::javax.crypto.SecretKey engineGenerateSecret(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.SecretKeyFactorySpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		static SecretKeyFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactorySpi"));
		}
	}
}
