namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyFactorySpi_))]
	public abstract partial class KeyFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGeneratePublic23024;
		protected abstract global::java.security.PublicKey engineGeneratePublic(java.security.spec.KeySpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineGeneratePrivate23025;
		protected abstract global::java.security.PrivateKey engineGeneratePrivate(java.security.spec.KeySpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec23026;
		protected abstract global::java.security.spec.KeySpec engineGetKeySpec(java.security.Key arg0, java.lang.Class arg1);
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey23027;
		protected abstract global::java.security.Key engineTranslateKey(java.security.Key arg0);
		internal static global::MonoJavaBridge.MethodId _KeyFactorySpi23028;
		public KeyFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyFactorySpi._KeyFactorySpi23028.native == global::System.IntPtr.Zero)
				global::java.security.KeyFactorySpi._KeyFactorySpi23028 = @__env.GetMethodIDNoThrow(global::java.security.KeyFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyFactorySpi.staticClass, global::java.security.KeyFactorySpi._KeyFactorySpi23028);
			Init(@__env, handle);
		}
		static KeyFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactorySpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyFactorySpi))]
	internal sealed partial class KeyFactorySpi_ : java.security.KeyFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGeneratePublic23029;
		protected override global::java.security.PublicKey engineGeneratePublic(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PublicKey>(this, global::java.security.KeyFactorySpi_.staticClass, "engineGeneratePublic", "(Ljava/security/spec/KeySpec;)Ljava/security/PublicKey;", ref global::java.security.KeyFactorySpi_._engineGeneratePublic23029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PublicKey;
		}
		internal static global::MonoJavaBridge.MethodId _engineGeneratePrivate23030;
		protected override global::java.security.PrivateKey engineGeneratePrivate(java.security.spec.KeySpec arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.PrivateKey>(this, global::java.security.KeyFactorySpi_.staticClass, "engineGeneratePrivate", "(Ljava/security/spec/KeySpec;)Ljava/security/PrivateKey;", ref global::java.security.KeyFactorySpi_._engineGeneratePrivate23030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.PrivateKey;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec23031;
		protected override global::java.security.spec.KeySpec engineGetKeySpec(java.security.Key arg0, java.lang.Class arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.KeySpec>(this, global::java.security.KeyFactorySpi_.staticClass, "engineGetKeySpec", "(Ljava/security/Key;Ljava/lang/Class;)Ljava/security/spec/KeySpec;", ref global::java.security.KeyFactorySpi_._engineGetKeySpec23031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey23032;
		protected override global::java.security.Key engineTranslateKey(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::java.security.KeyFactorySpi_.staticClass, "engineTranslateKey", "(Ljava/security/Key;)Ljava/security/Key;", ref global::java.security.KeyFactorySpi_._engineTranslateKey23032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.Key;
		}
		static KeyFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyFactorySpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
