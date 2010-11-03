namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyFactorySpi_))]
	public abstract partial class KeyFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract global::java.security.PublicKey engineGeneratePublic(java.security.spec.KeySpec arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract global::java.security.PrivateKey engineGeneratePrivate(java.security.spec.KeySpec arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::java.security.spec.KeySpec engineGetKeySpec(java.security.Key arg0, java.lang.Class arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract global::java.security.Key engineTranslateKey(java.security.Key arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		public KeyFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyFactorySpi._m4.native == global::System.IntPtr.Zero)
				global::java.security.KeyFactorySpi._m4 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyFactorySpi.staticClass, global::java.security.KeyFactorySpi._m4);
			Init(@__env, handle);
		}
		static KeyFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactorySpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyFactorySpi))]
	internal sealed partial class KeyFactorySpi_ : java.security.KeyFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.security.PublicKey engineGeneratePublic(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.KeyFactorySpi_.staticClass, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", ref global::java.security.KeyFactorySpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PublicKey;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override global::java.security.PrivateKey engineGeneratePrivate(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::java.security.KeyFactorySpi_.staticClass, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", ref global::java.security.KeyFactorySpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PrivateKey;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.security.spec.KeySpec engineGetKeySpec(java.security.Key arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.KeySpec>(this, global::java.security.KeyFactorySpi_.staticClass, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", ref global::java.security.KeyFactorySpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.KeySpec;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::java.security.Key engineTranslateKey(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::java.security.KeyFactorySpi_.staticClass, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;", ref global::java.security.KeyFactorySpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Key;
		}
		static KeyFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactorySpi"));
		}
	}
}
