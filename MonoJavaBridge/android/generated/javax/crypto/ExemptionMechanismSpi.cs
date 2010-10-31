namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.ExemptionMechanismSpi_))]
	public abstract partial class ExemptionMechanismSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExemptionMechanismSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(java.security.Key arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void engineInit(java.security.Key arg0, java.security.AlgorithmParameters arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract int engineGetOutputSize(int arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract byte[] engineGenExemptionBlob();
		private static global::MonoJavaBridge.MethodId _m5;
		protected abstract int engineGenExemptionBlob(byte[] arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m6;
		public ExemptionMechanismSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi._m6.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi._m6 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismSpi.staticClass, global::javax.crypto.ExemptionMechanismSpi._m6);
			Init(@__env, handle);
		}
		static ExemptionMechanismSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.ExemptionMechanismSpi))]
	internal sealed partial class ExemptionMechanismSpi_ : javax.crypto.ExemptionMechanismSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ExemptionMechanismSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(java.security.Key arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;)V", ref global::javax.crypto.ExemptionMechanismSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.ExemptionMechanismSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void engineInit(java.security.Key arg0, java.security.AlgorithmParameters arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V", ref global::javax.crypto.ExemptionMechanismSpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override int engineGetOutputSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGetOutputSize", "(I)I", ref global::javax.crypto.ExemptionMechanismSpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override byte[] engineGenExemptionBlob()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGenExemptionBlob", "()[B", ref global::javax.crypto.ExemptionMechanismSpi_._m4) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override int engineGenExemptionBlob(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGenExemptionBlob", "([BI)I", ref global::javax.crypto.ExemptionMechanismSpi_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ExemptionMechanismSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismSpi"));
		}
	}
}
