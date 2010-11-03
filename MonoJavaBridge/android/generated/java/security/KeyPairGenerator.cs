namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyPairGenerator_))]
	public abstract partial class KeyPairGenerator : java.security.KeyPairGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyPairGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyPairGenerator._m0.native == global::System.IntPtr.Zero)
				global::java.security.KeyPairGenerator._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyPairGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyPairGenerator._m1.native == global::System.IntPtr.Zero)
				global::java.security.KeyPairGenerator._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/KeyPairGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.KeyPairGenerator getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyPairGenerator._m2.native == global::System.IntPtr.Zero)
				global::java.security.KeyPairGenerator._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/KeyPairGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.KeyPairGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.KeyPairGenerator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyPairGenerator.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::java.security.KeyPairGenerator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void initialize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyPairGenerator.staticClass, "initialize", "(I)V", ref global::java.security.KeyPairGenerator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override void initialize(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.KeyPairGenerator.staticClass, "initialize", "(ILjava/security/SecureRandom;)V", ref global::java.security.KeyPairGenerator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.KeyPairGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.KeyPairGenerator._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyPairGenerator.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.KeyPairGenerator._m8) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.security.KeyPair genKeyPair()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.security.KeyPair>(this, global::java.security.KeyPairGenerator.staticClass, "genKeyPair", "()Ljava/security/KeyPair;", ref global::java.security.KeyPairGenerator._m9) as java.security.KeyPair;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.security.KeyPair generateKeyPair()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.security.KeyPair>(this, global::java.security.KeyPairGenerator.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;", ref global::java.security.KeyPairGenerator._m10) as java.security.KeyPair;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected KeyPairGenerator(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyPairGenerator._m11.native == global::System.IntPtr.Zero)
				global::java.security.KeyPairGenerator._m11 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGenerator.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGenerator.staticClass, global::java.security.KeyPairGenerator._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static KeyPairGenerator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGenerator"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyPairGenerator))]
	internal sealed partial class KeyPairGenerator_ : java.security.KeyPairGenerator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyPairGenerator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static KeyPairGenerator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGenerator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGenerator"));
		}
	}
}
