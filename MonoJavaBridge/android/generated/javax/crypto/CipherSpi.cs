namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.CipherSpi_))]
	public abstract partial class CipherSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CipherSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28549;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2);
		internal static global::MonoJavaBridge.MethodId _engineInit28550;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3);
		internal static global::MonoJavaBridge.MethodId _engineInit28551;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28552;
		protected abstract byte[] engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28553;
		protected abstract int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28554;
		protected virtual int engineUpdate(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", ref global::javax.crypto.CipherSpi._engineUpdate28554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameters28555;
		protected abstract global::java.security.AlgorithmParameters engineGetParameters();
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28556;
		protected abstract int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28557;
		protected abstract byte[] engineDoFinal(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28558;
		protected virtual int engineDoFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", ref global::javax.crypto.CipherSpi._engineDoFinal28558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetBlockSize28559;
		protected abstract int engineGetBlockSize();
		internal static global::MonoJavaBridge.MethodId _engineGetIV28560;
		protected abstract byte[] engineGetIV();
		internal static global::MonoJavaBridge.MethodId _engineGetKeySize28561;
		protected virtual int engineGetKeySize(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi.staticClass, "engineGetKeySize", "(Ljava/security/Key;)I", ref global::javax.crypto.CipherSpi._engineGetKeySize28561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize28562;
		protected abstract int engineGetOutputSize(int arg0);
		internal static global::MonoJavaBridge.MethodId _engineUnwrap28563;
		protected virtual global::java.security.Key engineUnwrap(byte[] arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::javax.crypto.CipherSpi.staticClass, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;", ref global::javax.crypto.CipherSpi._engineUnwrap28563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineWrap28564;
		protected virtual byte[] engineWrap(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi.staticClass, "engineWrap", "(Ljava/security/Key;)[B", ref global::javax.crypto.CipherSpi._engineWrap28564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineSetMode28565;
		protected abstract void engineSetMode(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSetPadding28566;
		protected abstract void engineSetPadding(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _CipherSpi28567;
		public CipherSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherSpi._CipherSpi28567.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherSpi._CipherSpi28567 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._CipherSpi28567);
			Init(@__env, handle);
		}
		static CipherSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.CipherSpi))]
	internal sealed partial class CipherSpi_ : javax.crypto.CipherSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CipherSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28568;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", ref global::javax.crypto.CipherSpi_._engineInit28568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28569;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V", ref global::javax.crypto.CipherSpi_._engineInit28569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28570;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.CipherSpi_._engineInit28570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28571;
		protected override byte[] engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII)[B", ref global::javax.crypto.CipherSpi_._engineUpdate28571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28572;
		protected override int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII[BI)I", ref global::javax.crypto.CipherSpi_._engineUpdate28572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameters28573;
		protected override global::java.security.AlgorithmParameters engineGetParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;", ref global::javax.crypto.CipherSpi_._engineGetParameters28573) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28574;
		protected override int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII[BI)I", ref global::javax.crypto.CipherSpi_._engineDoFinal28574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28575;
		protected override byte[] engineDoFinal(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII)[B", ref global::javax.crypto.CipherSpi_._engineDoFinal28575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetBlockSize28576;
		protected override int engineGetBlockSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetBlockSize", "()I", ref global::javax.crypto.CipherSpi_._engineGetBlockSize28576);
		}
		internal static global::MonoJavaBridge.MethodId _engineGetIV28577;
		protected override byte[] engineGetIV()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetIV", "()[B", ref global::javax.crypto.CipherSpi_._engineGetIV28577) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize28578;
		protected override int engineGetOutputSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetOutputSize", "(I)I", ref global::javax.crypto.CipherSpi_._engineGetOutputSize28578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetMode28579;
		protected override void engineSetMode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineSetMode", "(Ljava/lang/String;)V", ref global::javax.crypto.CipherSpi_._engineSetMode28579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetPadding28580;
		protected override void engineSetPadding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineSetPadding", "(Ljava/lang/String;)V", ref global::javax.crypto.CipherSpi_._engineSetPadding28580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CipherSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
