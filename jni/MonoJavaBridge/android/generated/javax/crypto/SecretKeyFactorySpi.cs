namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.SecretKeyFactorySpi_))]
	public abstract partial class SecretKeyFactorySpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecretKeyFactorySpi()
		{
			InitJNI();
		}
		protected SecretKeyFactorySpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec22711;
		protected abstract global::java.security.spec.KeySpec engineGetKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1);
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey22712;
		protected abstract global::javax.crypto.SecretKey engineTranslateKey(javax.crypto.SecretKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret22713;
		protected abstract global::javax.crypto.SecretKey engineGenerateSecret(java.security.spec.KeySpec arg0);
		internal static global::MonoJavaBridge.MethodId _SecretKeyFactorySpi22714;
		public SecretKeyFactorySpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.SecretKeyFactorySpi.staticClass, global::javax.crypto.SecretKeyFactorySpi._SecretKeyFactorySpi22714);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactorySpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactorySpi"));
			global::javax.crypto.SecretKeyFactorySpi._engineGetKeySpec22711 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi.staticClass, "engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::javax.crypto.SecretKeyFactorySpi._engineTranslateKey22712 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi.staticClass, "engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.SecretKeyFactorySpi._engineGenerateSecret22713 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi.staticClass, "engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.SecretKeyFactorySpi._SecretKeyFactorySpi22714 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.SecretKeyFactorySpi))]
	public sealed partial class SecretKeyFactorySpi_ : javax.crypto.SecretKeyFactorySpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SecretKeyFactorySpi_()
		{
			InitJNI();
		}
		internal SecretKeyFactorySpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineGetKeySpec22715;
		protected override global::java.security.spec.KeySpec engineGetKeySpec(javax.crypto.SecretKey arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_._engineGetKeySpec22715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.spec.KeySpec>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_.staticClass, global::javax.crypto.SecretKeyFactorySpi_._engineGetKeySpec22715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.spec.KeySpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineTranslateKey22716;
		protected override global::javax.crypto.SecretKey engineTranslateKey(javax.crypto.SecretKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_._engineTranslateKey22716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_.staticClass, global::javax.crypto.SecretKeyFactorySpi_._engineTranslateKey22716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret22717;
		protected override global::javax.crypto.SecretKey engineGenerateSecret(java.security.spec.KeySpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_._engineGenerateSecret22717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.SecretKeyFactorySpi_.staticClass, global::javax.crypto.SecretKeyFactorySpi_._engineGenerateSecret22717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.SecretKeyFactorySpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/SecretKeyFactorySpi"));
			global::javax.crypto.SecretKeyFactorySpi_._engineGetKeySpec22715 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineGetKeySpec", "(Ljavax/crypto/SecretKey;Ljava/lang/Class;)Ljava/security/spec/KeySpec;");
			global::javax.crypto.SecretKeyFactorySpi_._engineTranslateKey22716 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineTranslateKey", "(Ljavax/crypto/SecretKey;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.SecretKeyFactorySpi_._engineGenerateSecret22717 = @__env.GetMethodIDNoThrow(global::javax.crypto.SecretKeyFactorySpi_.staticClass, "engineGenerateSecret", "(Ljava/security/spec/KeySpec;)Ljavax/crypto/SecretKey;");
		}
	}
}
