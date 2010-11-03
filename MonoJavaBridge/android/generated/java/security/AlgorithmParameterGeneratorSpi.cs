namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AlgorithmParameterGeneratorSpi_))]
	public abstract partial class AlgorithmParameterGeneratorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParameterGeneratorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(int arg0, java.security.SecureRandom arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::java.security.AlgorithmParameters engineGenerateParameters();
		private static global::MonoJavaBridge.MethodId _m3;
		public AlgorithmParameterGeneratorSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameterGeneratorSpi._m3.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameterGeneratorSpi._m3 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGeneratorSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameterGeneratorSpi.staticClass, global::java.security.AlgorithmParameterGeneratorSpi._m3);
			Init(@__env, handle);
		}
		static AlgorithmParameterGeneratorSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGeneratorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGeneratorSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AlgorithmParameterGeneratorSpi))]
	internal sealed partial class AlgorithmParameterGeneratorSpi_ : java.security.AlgorithmParameterGeneratorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlgorithmParameterGeneratorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, "engineInit", "(ILjava/security/SecureRandom;)V", ref global::java.security.AlgorithmParameterGeneratorSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::java.security.AlgorithmParameterGeneratorSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.security.AlgorithmParameters engineGenerateParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AlgorithmParameterGeneratorSpi_.staticClass, "engineGenerateParameters", "()Ljava/security/AlgorithmParameters;", ref global::java.security.AlgorithmParameterGeneratorSpi_._m2) as java.security.AlgorithmParameters;
		}
		static AlgorithmParameterGeneratorSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGeneratorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGeneratorSpi"));
		}
	}
}
