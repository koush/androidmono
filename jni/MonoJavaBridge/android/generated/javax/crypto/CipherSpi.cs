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
		internal static global::MonoJavaBridge.MethodId _engineInit22534;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2);
		internal static global::MonoJavaBridge.MethodId _engineInit22535;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3);
		internal static global::MonoJavaBridge.MethodId _engineInit22536;
		protected abstract void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3);
		internal static global::MonoJavaBridge.MethodId _engineUpdate22537;
		protected abstract byte[] engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate22538;
		protected abstract int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _engineUpdate22539;
		protected virtual int engineUpdate(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineUpdate22539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineUpdate22539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameters22540;
		protected abstract global::java.security.AlgorithmParameters engineGetParameters();
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22541;
		protected abstract int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4);
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22542;
		protected abstract byte[] engineDoFinal(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22543;
		protected virtual int engineDoFinal(java.nio.ByteBuffer arg0, java.nio.ByteBuffer arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineDoFinal22543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineDoFinal22543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetBlockSize22544;
		protected abstract int engineGetBlockSize();
		internal static global::MonoJavaBridge.MethodId _engineGetIV22545;
		protected abstract byte[] engineGetIV();
		internal static global::MonoJavaBridge.MethodId _engineGetKeySize22546;
		protected virtual int engineGetKeySize(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineGetKeySize22546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineGetKeySize22546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize22547;
		protected abstract int engineGetOutputSize(int arg0);
		internal static global::MonoJavaBridge.MethodId _engineUnwrap22548;
		protected virtual global::java.security.Key engineUnwrap(byte[] arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineUnwrap22548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.Key>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineUnwrap22548, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.security.Key;
		}
		internal static global::MonoJavaBridge.MethodId _engineWrap22549;
		protected virtual byte[] engineWrap(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi._engineWrap22549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._engineWrap22549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineSetMode22550;
		protected abstract void engineSetMode(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineSetPadding22551;
		protected abstract void engineSetPadding(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _CipherSpi22552;
		public CipherSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.CipherSpi.staticClass, global::javax.crypto.CipherSpi._CipherSpi22552);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
			global::javax.crypto.CipherSpi._engineInit22534 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi._engineInit22535 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi._engineInit22536 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi._engineUpdate22537 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "([BII)[B");
			global::javax.crypto.CipherSpi._engineUpdate22538 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "([BII[BI)I");
			global::javax.crypto.CipherSpi._engineUpdate22539 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.CipherSpi._engineGetParameters22540 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.CipherSpi._engineDoFinal22541 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "([BII[BI)I");
			global::javax.crypto.CipherSpi._engineDoFinal22542 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "([BII)[B");
			global::javax.crypto.CipherSpi._engineDoFinal22543 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineDoFinal", "(Ljava/nio/ByteBuffer;Ljava/nio/ByteBuffer;)I");
			global::javax.crypto.CipherSpi._engineGetBlockSize22544 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetBlockSize", "()I");
			global::javax.crypto.CipherSpi._engineGetIV22545 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetIV", "()[B");
			global::javax.crypto.CipherSpi._engineGetKeySize22546 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetKeySize", "(Ljava/security/Key;)I");
			global::javax.crypto.CipherSpi._engineGetOutputSize22547 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineGetOutputSize", "(I)I");
			global::javax.crypto.CipherSpi._engineUnwrap22548 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineUnwrap", "([BLjava/lang/String;I)Ljava/security/Key;");
			global::javax.crypto.CipherSpi._engineWrap22549 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineWrap", "(Ljava/security/Key;)[B");
			global::javax.crypto.CipherSpi._engineSetMode22550 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineSetMode", "(Ljava/lang/String;)V");
			global::javax.crypto.CipherSpi._engineSetPadding22551 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "engineSetPadding", "(Ljava/lang/String;)V");
			global::javax.crypto.CipherSpi._CipherSpi22552 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.CipherSpi))]
	public sealed partial class CipherSpi_ : javax.crypto.CipherSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CipherSpi_()
		{
			InitJNI();
		}
		internal CipherSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22553;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.SecureRandom arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineInit22553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineInit22553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22554;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.AlgorithmParameters arg2, java.security.SecureRandom arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineInit22554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineInit22554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22555;
		protected override void engineInit(int arg0, java.security.Key arg1, java.security.spec.AlgorithmParameterSpec arg2, java.security.SecureRandom arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineInit22555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineInit22555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate22556;
		protected override byte[] engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineUpdate22556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineUpdate22556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate22557;
		protected override int engineUpdate(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineUpdate22557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineUpdate22557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameters22558;
		protected override global::java.security.AlgorithmParameters engineGetParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetParameters22558)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetParameters22558)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22559;
		protected override int engineDoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineDoFinal22559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineDoFinal22559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22560;
		protected override byte[] engineDoFinal(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineDoFinal22560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineDoFinal22560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetBlockSize22561;
		protected override int engineGetBlockSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetBlockSize22561);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetBlockSize22561);
		}
		internal static global::MonoJavaBridge.MethodId _engineGetIV22562;
		protected override byte[] engineGetIV() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetIV22562)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetIV22562)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize22563;
		protected override int engineGetOutputSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineGetOutputSize22563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineGetOutputSize22563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetMode22564;
		protected override void engineSetMode(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineSetMode22564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineSetMode22564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetPadding22565;
		protected override void engineSetPadding(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_._engineSetPadding22565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.CipherSpi_.staticClass, global::javax.crypto.CipherSpi_._engineSetPadding22565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.CipherSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/CipherSpi"));
			global::javax.crypto.CipherSpi_._engineInit22553 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi_._engineInit22554 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/AlgorithmParameters;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi_._engineInit22555 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineInit", "(ILjava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V");
			global::javax.crypto.CipherSpi_._engineUpdate22556 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII)[B");
			global::javax.crypto.CipherSpi_._engineUpdate22557 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineUpdate", "([BII[BI)I");
			global::javax.crypto.CipherSpi_._engineGetParameters22558 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::javax.crypto.CipherSpi_._engineDoFinal22559 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII[BI)I");
			global::javax.crypto.CipherSpi_._engineDoFinal22560 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineDoFinal", "([BII)[B");
			global::javax.crypto.CipherSpi_._engineGetBlockSize22561 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetBlockSize", "()I");
			global::javax.crypto.CipherSpi_._engineGetIV22562 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetIV", "()[B");
			global::javax.crypto.CipherSpi_._engineGetOutputSize22563 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineGetOutputSize", "(I)I");
			global::javax.crypto.CipherSpi_._engineSetMode22564 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineSetMode", "(Ljava/lang/String;)V");
			global::javax.crypto.CipherSpi_._engineSetPadding22565 = @__env.GetMethodIDNoThrow(global::javax.crypto.CipherSpi_.staticClass, "engineSetPadding", "(Ljava/lang/String;)V");
		}
	}
}
