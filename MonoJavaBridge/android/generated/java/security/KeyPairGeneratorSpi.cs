namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyPairGeneratorSpi_))]
	public abstract partial class KeyPairGeneratorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyPairGeneratorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void initialize(int arg0, java.security.SecureRandom arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyPairGeneratorSpi.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::java.security.KeyPairGeneratorSpi._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract global::java.security.KeyPair generateKeyPair();
		private static global::MonoJavaBridge.MethodId _m3;
		public KeyPairGeneratorSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyPairGeneratorSpi._m3.native == global::System.IntPtr.Zero)
				global::java.security.KeyPairGeneratorSpi._m3 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGeneratorSpi.staticClass, global::java.security.KeyPairGeneratorSpi._m3);
			Init(@__env, handle);
		}
		static KeyPairGeneratorSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGeneratorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGeneratorSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyPairGeneratorSpi))]
	internal sealed partial class KeyPairGeneratorSpi_ : java.security.KeyPairGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyPairGeneratorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void initialize(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyPairGeneratorSpi_.staticClass, "initialize", "(ILjava/security/SecureRandom;)V", ref global::java.security.KeyPairGeneratorSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.security.KeyPair generateKeyPair()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.security.KeyPair>(this, global::java.security.KeyPairGeneratorSpi_.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;", ref global::java.security.KeyPairGeneratorSpi_._m1) as java.security.KeyPair;
		}
		static KeyPairGeneratorSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGeneratorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGeneratorSpi"));
		}
	}
}
