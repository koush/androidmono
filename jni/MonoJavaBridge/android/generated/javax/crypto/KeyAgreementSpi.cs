namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.KeyAgreementSpi_))]
	public abstract partial class KeyAgreementSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyAgreementSpi()
		{
			InitJNI();
		}
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
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.KeyAgreementSpi.staticClass, global::javax.crypto.KeyAgreementSpi._KeyAgreementSpi28644);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreementSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreementSpi"));
			global::javax.crypto.KeyAgreementSpi._engineInit28638 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreementSpi._engineInit28639 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreementSpi._engineDoPhase28640 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;");
			global::javax.crypto.KeyAgreementSpi._engineGenerateSecret28641 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "engineGenerateSecret", "()[B");
			global::javax.crypto.KeyAgreementSpi._engineGenerateSecret28642 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "engineGenerateSecret", "([BI)I");
			global::javax.crypto.KeyAgreementSpi._engineGenerateSecret28643 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;");
			global::javax.crypto.KeyAgreementSpi._KeyAgreementSpi28644 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.KeyAgreementSpi))]
	internal sealed partial class KeyAgreementSpi_ : javax.crypto.KeyAgreementSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyAgreementSpi_()
		{
			InitJNI();
		}
		internal KeyAgreementSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28645;
		protected override void engineInit(java.security.Key arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_._engineInit28645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_.staticClass, global::javax.crypto.KeyAgreementSpi_._engineInit28645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28646;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_._engineInit28646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_.staticClass, global::javax.crypto.KeyAgreementSpi_._engineInit28646, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineDoPhase28647;
		protected override global::java.security.Key engineDoPhase(java.security.Key arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_._engineDoPhase28647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_.staticClass, global::javax.crypto.KeyAgreementSpi_._engineDoPhase28647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28648;
		protected override byte[] engineGenerateSecret()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28648)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_.staticClass, global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28648)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28649;
		protected override int engineGenerateSecret(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_.staticClass, global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28649, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenerateSecret28650;
		protected override global::javax.crypto.SecretKey engineGenerateSecret(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.crypto.SecretKey>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.KeyAgreementSpi_.staticClass, global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.crypto.SecretKey;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.KeyAgreementSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/KeyAgreementSpi"));
			global::javax.crypto.KeyAgreementSpi_._engineInit28645 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreementSpi_._engineInit28646 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.KeyAgreementSpi_._engineDoPhase28647 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi_.staticClass, "engineDoPhase", "(Ljava/security/Key;Z)Ljava/security/Key;");
			global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28648 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "()[B");
			global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28649 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "([BI)I");
			global::javax.crypto.KeyAgreementSpi_._engineGenerateSecret28650 = @__env.GetMethodIDNoThrow(global::javax.crypto.KeyAgreementSpi_.staticClass, "engineGenerateSecret", "(Ljava/lang/String;)Ljavax/crypto/SecretKey;");
		}
	}
}
