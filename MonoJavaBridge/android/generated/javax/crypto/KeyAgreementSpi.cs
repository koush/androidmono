namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.KeyAgreementSpi_))]
	public abstract partial class KeyAgreementSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyAgreementSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28638;
		protected abstract void engineInit(java.security.Key arg0, java.security.SecureRandom arg1);
		internal static global::MonoJavaBridge.MethodId _engineInit28639;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2);
		internal static global::MonoJavaBridge.MethodId _engineDoPhase28640;
		protected abstract global::java.security.Key engineDoPhase(java.security.Key arg0, bool arg1);
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28641;
		protected abstract byte[] engineGenerateSecret();
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28642;
		protected abstract int engineGenerateSecret(byte[] arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28643;
		protected abstract global::javax.crypto.SecretKey engineGenerateSecret(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _KeyAgreementSpi28644;
		public KeyAgreementSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.KeyAgreementSpi._KeyAgreementSpi28644.native == global::System.IntPtr.Zero)
				global::javax.crypto.KeyAgreementSpi._KeyAgreementSpi28644 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyAgreementSpi.staticClass, global::javax.crypto.KeyAgreementSpi._KeyAgreementSpi28644);
			Init(@__env, handle);
		}
		static KeyAgreementSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreementSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreementSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.KeyAgreementSpi))]
	internal sealed partial class KeyAgreementSpi_ : javax.crypto.KeyAgreementSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal KeyAgreementSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28645;
		protected override void engineInit(java.security.Key arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyAgreementSpi_._engineInit28645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28646;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.KeyAgreementSpi_._engineInit28646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDoPhase28647;
		protected override global::java.security.Key engineDoPhase(java.security.Key arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;", ref global::javax.crypto.KeyAgreementSpi_._engineDoPhase28647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28648;
		protected override byte[] engineGenerateSecret()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "()[B", ref global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28648) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28649;
		protected override int engineGenerateSecret(byte[] arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "([BI)I", ref global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28650;
		protected override global::javax.crypto.SecretKey engineGenerateSecret(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<javax.crypto.SecretKey>(this, global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;", ref global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.crypto.SecretKey;
		}
		static KeyAgreementSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreementSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreementSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
