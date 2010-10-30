namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.SecretKeyFactorySpi_))]
	public abstract partial class SecretKeyFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SecretKeyFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec28727;
		protected abstract global::java.security.spec.KeySpec engineGetKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1);
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey28728;
		protected abstract global::javax.crypto.SecretKey engineTranslateKey(javax.crypto.SecretKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28729;
		protected abstract global::javax.crypto.SecretKey engineGenerateSecret(java.security.spec.KeySpec arg0);
		internal static global::MonoJavaBridge.MethodId _SecretKeyFactorySpi28730;
		public SecretKeyFactorySpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactorySpi._SecretKeyFactorySpi28730.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactorySpi._SecretKeyFactorySpi28730 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SecretKeyFactorySpi.staticClass, global::javax.crypto.SecretKeyFactorySpi._SecretKeyFactorySpi28730);
			Init(@__env, handle);
		}
		static SecretKeyFactorySpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactorySpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.SecretKeyFactorySpi))]
	internal sealed partial class SecretKeyFactorySpi_ : javax.crypto.SecretKeyFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecretKeyFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec28731;
		protected override global::java.security.spec.KeySpec engineGetKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactorySpi_._engineGetKeySpec28731.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactorySpi_._engineGetKeySpec28731 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_._engineGetKeySpec28731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey28732;
		protected override global::javax.crypto.SecretKey engineTranslateKey(javax.crypto.SecretKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactorySpi_._engineTranslateKey28732.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactorySpi_._engineTranslateKey28732 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_._engineTranslateKey28732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28733;
		protected override global::javax.crypto.SecretKey engineGenerateSecret(java.security.spec.KeySpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.SecretKeyFactorySpi_._engineGenerateSecret28733.native == global::System.IntPtr.Zero)
				global::javax.crypto.SecretKeyFactorySpi_._engineGenerateSecret28733 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_._engineGenerateSecret28733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		static SecretKeyFactorySpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactorySpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
