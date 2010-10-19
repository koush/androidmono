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
		internal static global::MonoJavaBridge.MethodId _initialize17334;
		public abstract void initialize(int arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _initialize17335;
		public virtual void initialize(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi._initialize17335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi.staticClass, global::java.security.KeyPairGeneratorSpi._initialize17335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair17336;
		public abstract global::java.security.KeyPair generateKeyPair();
		internal static global::MonoJavaBridge.MethodId _KeyPairGeneratorSpi17337;
		public KeyPairGeneratorSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyPairGeneratorSpi.staticClass, global::java.security.KeyPairGeneratorSpi._KeyPairGeneratorSpi17337);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGeneratorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGeneratorSpi"));
			global::java.security.KeyPairGeneratorSpi._initialize17334 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGeneratorSpi._initialize17335 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "initialize", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::java.security.KeyPairGeneratorSpi._generateKeyPair17336 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
			global::java.security.KeyPairGeneratorSpi._KeyPairGeneratorSpi17337 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.KeyPairGeneratorSpi))]
	public sealed partial class KeyPairGeneratorSpi_ : java.security.KeyPairGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyPairGeneratorSpi_()
		{
			InitJNI();
		}
		internal KeyPairGeneratorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _initialize17338;
		public override void initialize(int arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_._initialize17338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_.staticClass, global::java.security.KeyPairGeneratorSpi_._initialize17338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _generateKeyPair17339;
		public override global::java.security.KeyPair generateKeyPair() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_._generateKeyPair17339)) as java.security.KeyPair;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyPairGeneratorSpi_.staticClass, global::java.security.KeyPairGeneratorSpi_._generateKeyPair17339)) as java.security.KeyPair;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyPairGeneratorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyPairGeneratorSpi"));
			global::java.security.KeyPairGeneratorSpi_._initialize17338 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi_.staticClass, "initialize", "(ILjava/security/SecureRandom;)V");
			global::java.security.KeyPairGeneratorSpi_._generateKeyPair17339 = @__env.GetMethodIDNoThrow(global::java.security.KeyPairGeneratorSpi_.staticClass, "generateKeyPair", "()Ljava/security/KeyPair;");
		}
	}
}
