namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.CipherSpi_))]
	public abstract partial class CipherSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CipherSpi()
		{
			InitJNI();
		}
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineUpdate28554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineUpdate28554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
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
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineDoFinal28558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineDoFinal28558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetBlockSize28559;
		protected abstract int engineGetBlockSize();
		internal static global::MonoJavaBridge.MethodId _engineGetIV28560;
		protected abstract byte[] engineGetIV();
		internal static global::MonoJavaBridge.MethodId _engineGetKeySize28561;
		protected virtual int engineGetKeySize(java.security.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineGetKeySize28561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineGetKeySize28561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize28562;
		protected abstract int engineGetOutputSize(int arg0);
		internal static global::MonoJavaBridge.MethodId _engineUnwrap28563;
		protected virtual global::java.security.Key engineUnwrap(byte[] arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineUnwrap28563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineUnwrap28563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineWrap28564;
		protected virtual byte[] engineWrap(java.security.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineWrap28564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineWrap28564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineSetMode28565;
		protected abstract void engineSetMode(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSetPadding28566;
		protected abstract void engineSetPadding(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _CipherSpi28567;
		public CipherSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._CipherSpi28567);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
			global::javax.crypto.CipherSpi._engineInit28549 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi._engineInit28550 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi._engineInit28551 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi._engineUpdate28552 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "([BII)[B");
			global::javax.crypto.CipherSpi._engineUpdate28553 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "([BII[BI)I");
			global::javax.crypto.CipherSpi._engineUpdate28554 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.CipherSpi._engineGetParameters28555 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.CipherSpi._engineDoFinal28556 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "([BII[BI)I");
			global::javax.crypto.CipherSpi._engineDoFinal28557 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "([BII)[B");
			global::javax.crypto.CipherSpi._engineDoFinal28558 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.CipherSpi._engineGetBlockSize28559 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetBlockSize", "()I");
			global::javax.crypto.CipherSpi._engineGetIV28560 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetIV", "()[B");
			global::javax.crypto.CipherSpi._engineGetKeySize28561 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetKeySize", "(Ljava/security/Key;)I");
			global::javax.crypto.CipherSpi._engineGetOutputSize28562 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetOutputSize", "(I)I");
			global::javax.crypto.CipherSpi._engineUnwrap28563 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;");
			global::javax.crypto.CipherSpi._engineWrap28564 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineWrap", "(Ljava/security/Key;)[B");
			global::javax.crypto.CipherSpi._engineSetMode28565 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineSetMode", "(Ljava/lang/String;)V");
			global::javax.crypto.CipherSpi._engineSetPadding28566 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineSetPadding", "(Ljava/lang/String;)V");
			global::javax.crypto.CipherSpi._CipherSpi28567 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.CipherSpi))]
	internal sealed partial class CipherSpi_ : javax.crypto.CipherSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CipherSpi_()
		{
			InitJNI();
		}
		internal CipherSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28568;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineInit28568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineInit28568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28569;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineInit28569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineInit28569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28570;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineInit28570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineInit28570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28571;
		protected override byte[] engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineUpdate28571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineUpdate28571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28572;
		protected override int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineUpdate28572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineUpdate28572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameters28573;
		protected override global::java.security.AlgorithmParameters engineGetParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetParameters28573)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetParameters28573)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28574;
		protected override int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineDoFinal28574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineDoFinal28574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28575;
		protected override byte[] engineDoFinal(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineDoFinal28575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineDoFinal28575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetBlockSize28576;
		protected override int engineGetBlockSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetBlockSize28576);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetBlockSize28576);
		}
		internal static global::MonoJavaBridge.MethodId _engineGetIV28577;
		protected override byte[] engineGetIV()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetIV28577)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetIV28577)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize28578;
		protected override int engineGetOutputSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetOutputSize28578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetOutputSize28578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetMode28579;
		protected override void engineSetMode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineSetMode28579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineSetMode28579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetPadding28580;
		protected override void engineSetPadding(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineSetPadding28580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineSetPadding28580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
			global::javax.crypto.CipherSpi_._engineInit28568 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi_._engineInit28569 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi_._engineInit28570 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi_._engineUpdate28571 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII)[B");
			global::javax.crypto.CipherSpi_._engineUpdate28572 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII[BI)I");
			global::javax.crypto.CipherSpi_._engineGetParameters28573 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.CipherSpi_._engineDoFinal28574 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII[BI)I");
			global::javax.crypto.CipherSpi_._engineDoFinal28575 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII)[B");
			global::javax.crypto.CipherSpi_._engineGetBlockSize28576 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetBlockSize", "()I");
			global::javax.crypto.CipherSpi_._engineGetIV28577 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetIV", "()[B");
			global::javax.crypto.CipherSpi_._engineGetOutputSize28578 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetOutputSize", "(I)I");
			global::javax.crypto.CipherSpi_._engineSetMode28579 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineSetMode", "(Ljava/lang/String;)V");
			global::javax.crypto.CipherSpi_._engineSetPadding28580 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineSetPadding", "(Ljava/lang/String;)V");
		}
	}
}
