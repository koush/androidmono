namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.CipherSpi_))]
	public abstract partial class CipherSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CipherSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract byte[] engineUpdate(byte[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4);
		private static global::MonoJavaBridge.MethodId _m5;
		protected virtual int engineUpdate(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", ref global::javax.crypto.CipherSpi._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract global::java.security.AlgorithmParameters engineGetParameters();
		private static global::MonoJavaBridge.MethodId _m7;
		protected abstract int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4);
		private static global::MonoJavaBridge.MethodId _m8;
		protected abstract byte[] engineDoFinal(byte[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual int engineDoFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I", ref global::javax.crypto.CipherSpi._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected abstract int engineGetBlockSize();
		private static global::MonoJavaBridge.MethodId _m11;
		protected abstract byte[] engineGetIV();
		private static global::MonoJavaBridge.MethodId _m12;
		protected virtual int engineGetKeySize(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi.staticClass, "engineGetKeySize", "(Ljava/security/Key;)I", ref global::javax.crypto.CipherSpi._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected abstract int engineGetOutputSize(int arg0);
		private static global::MonoJavaBridge.MethodId _m14;
		protected virtual global::java.security.Key engineUnwrap(byte[] arg0, java.lang.String arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.Key>(this, global::javax.crypto.CipherSpi.staticClass, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;", ref global::javax.crypto.CipherSpi._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.security.Key;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		protected virtual byte[] engineWrap(java.security.Key arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi.staticClass, "engineWrap", "(Ljava/security/Key;)[B", ref global::javax.crypto.CipherSpi._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		protected abstract void engineSetMode(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		protected abstract void engineSetPadding(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public CipherSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.CipherSpi._m18.native == global::System.IntPtr.Zero)
				global::javax.crypto.CipherSpi._m18 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._m18);
			Init(@__env, handle);
		}
		static CipherSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.CipherSpi))]
	internal sealed partial class CipherSpi_ : javax.crypto.CipherSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CipherSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V", ref global::javax.crypto.CipherSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V", ref global::javax.crypto.CipherSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::javax.crypto.CipherSpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override byte[] engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII)[B", ref global::javax.crypto.CipherSpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII[BI)I", ref global::javax.crypto.CipherSpi_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override global::java.security.AlgorithmParameters engineGetParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;", ref global::javax.crypto.CipherSpi_._m5) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII[BI)I", ref global::javax.crypto.CipherSpi_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override byte[] engineDoFinal(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII)[B", ref global::javax.crypto.CipherSpi_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected override int engineGetBlockSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetBlockSize", "()I", ref global::javax.crypto.CipherSpi_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected override byte[] engineGetIV()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetIV", "()[B", ref global::javax.crypto.CipherSpi_._m9) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected override int engineGetOutputSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineGetOutputSize", "(I)I", ref global::javax.crypto.CipherSpi_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected override void engineSetMode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineSetMode", "(Ljava/lang/String;)V", ref global::javax.crypto.CipherSpi_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected override void engineSetPadding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.CipherSpi_.staticClass, "engineSetPadding", "(Ljava/lang/String;)V", ref global::javax.crypto.CipherSpi_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static CipherSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
		}
	}
}
