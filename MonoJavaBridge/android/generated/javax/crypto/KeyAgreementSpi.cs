namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.KeyAgreementSpi_))]
	public abstract partial class KeyAgreementSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyAgreementSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(java.security.Key arg0, java.security.SecureRandom arg1);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract global::java.security.Key engineDoPhase(java.security.Key arg0, bool arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract byte[] engineGenerateSecret();
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract int engineGenerateSecret(byte[] arg0, int arg1);
		private static global::MonoJavaBridge.MethodId _m5;
		protected abstract global::javax.crypto.SecretKey engineGenerateSecret(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public KeyAgreementSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyAgreementSpi._m6.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyAgreementSpi._m6 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyAgreementSpi.staticClass, global::javax.crypto.KeyAgreementSpi._m6);
			Init(@__env, handle);
		}
		static KeyAgreementSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreementSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreementSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.KeyAgreementSpi))]
	internal sealed partial class KeyAgreementSpi_ : javax.crypto.KeyAgreementSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyAgreementSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(java.security.Key arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyAgreementSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyAgreementSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override global::java.security.Key engineDoPhase(java.security.Key arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", ref global::javax.crypto.KeyAgreementSpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override byte[] engineGenerateSecret()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "()[B", ref global::javax.crypto.KeyAgreementSpi_._m3) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override int engineGenerateSecret(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "([BI)I", ref global::javax.crypto.KeyAgreementSpi_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::javax.crypto.SecretKey engineGenerateSecret(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.KeyAgreementSpi_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		static KeyAgreementSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreementSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreementSpi"));
		}
	}
}
