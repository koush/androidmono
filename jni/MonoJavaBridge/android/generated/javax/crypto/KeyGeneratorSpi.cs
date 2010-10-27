namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.KeyGeneratorSpi_))]
	public abstract partial class KeyGeneratorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyGeneratorSpi()
		{
			InitJNI();
		}
		protected KeyGeneratorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28662;
		protected abstract void engineInit(java.security.SecureRandom arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit28663;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _engineInit28664;
		protected abstract void engineInit(int arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _engineGenerateKey28665;
		protected abstract global::javax.crypto.SecretKey engineGenerateKey();
		internal static global::MonoJavaBridge.MethodId _KeyGeneratorSpi28666;
		public KeyGeneratorSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyGeneratorSpi.staticClass, global::javax.crypto.KeyGeneratorSpi._KeyGeneratorSpi28666);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyGeneratorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyGeneratorSpi"));
			global::javax.crypto.KeyGeneratorSpi._engineInit28662 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi.staticClass, "engineInit", "(Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGeneratorSpi._engineInit28663 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGeneratorSpi._engineInit28664 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi.staticClass, "engineInit", "(ILjava/security/SecureRandom;)V");
			global::javax.crypto.KeyGeneratorSpi._engineGenerateKey28665 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi.staticClass, "engineGenerateKey", "()Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyGeneratorSpi._KeyGeneratorSpi28666 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.KeyGeneratorSpi))]
	internal sealed partial class KeyGeneratorSpi_ : javax.crypto.KeyGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyGeneratorSpi_()
		{
			InitJNI();
		}
		internal KeyGeneratorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28667;
		protected override void engineInit(java.security.SecureRandom arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_._engineInit28667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_.staticClass, global::javax.crypto.KeyGeneratorSpi_._engineInit28667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28668;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_._engineInit28668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_.staticClass, global::javax.crypto.KeyGeneratorSpi_._engineInit28668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28669;
		protected override void engineInit(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_._engineInit28669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_.staticClass, global::javax.crypto.KeyGeneratorSpi_._engineInit28669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateKey28670;
		protected override global::javax.crypto.SecretKey engineGenerateKey()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_._engineGenerateKey28670)) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyGeneratorSpi_.staticClass, global::javax.crypto.KeyGeneratorSpi_._engineGenerateKey28670)) as javax.crypto.SecretKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyGeneratorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyGeneratorSpi"));
			global::javax.crypto.KeyGeneratorSpi_._engineInit28667 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi_.staticClass, "engineInit", "(Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGeneratorSpi_._engineInit28668 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyGeneratorSpi_._engineInit28669 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi_.staticClass, "engineInit", "(ILjava/security/SecureRandom;)V");
			global::javax.crypto.KeyGeneratorSpi_._engineGenerateKey28670 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyGeneratorSpi_.staticClass, "engineGenerateKey", "()Ljavax/crypto/SecretKey;");
		}
	}
}
