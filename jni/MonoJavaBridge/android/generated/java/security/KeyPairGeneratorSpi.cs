namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.KeyPairGeneratorSpi_))]
	public abstract partial class KeyPairGeneratorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyPairGeneratorSpi()
		{
			InitJNI();
		}
		protected KeyPairGeneratorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize23051;
		public abstract void initialize(int arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _initialize23052;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi._initialize23052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi.staticClass, global::java.security.KeyPairGeneratorSpi._initialize23052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair23053;
		public abstract global::java.security.KeyPair generateKeyPair();
		internal static global::MonoJavaBridge.MethodId _KeyPairGeneratorSpi23054;
		public KeyPairGeneratorSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGeneratorSpi.staticClass, global::java.security.KeyPairGeneratorSpi._KeyPairGeneratorSpi23054);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGeneratorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGeneratorSpi"));
			global::java.security.KeyPairGeneratorSpi._initialize23051 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGeneratorSpi._initialize23052 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.KeyPairGeneratorSpi._generateKeyPair23053 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGeneratorSpi._KeyPairGeneratorSpi23054 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyPairGeneratorSpi))]
	internal sealed partial class KeyPairGeneratorSpi_ : java.security.KeyPairGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyPairGeneratorSpi_()
		{
			InitJNI();
		}
		internal KeyPairGeneratorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize23055;
		public override void initialize(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_._initialize23055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_.staticClass, global::java.security.KeyPairGeneratorSpi_._initialize23055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair23056;
		public override global::java.security.KeyPair generateKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyPair>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_._generateKeyPair23056)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyPair>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_.staticClass, global::java.security.KeyPairGeneratorSpi_._generateKeyPair23056)) as java.security.KeyPair;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGeneratorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGeneratorSpi"));
			global::java.security.KeyPairGeneratorSpi_._initialize23055 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi_.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGeneratorSpi_._generateKeyPair23056 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi_.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
		}
	}
}
