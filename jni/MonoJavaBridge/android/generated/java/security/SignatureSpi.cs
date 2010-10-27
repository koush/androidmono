namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.SignatureSpi_))]
	public abstract partial class SignatureSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SignatureSpi()
		{
			InitJNI();
		}
		protected SignatureSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone23373;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi._clone23373)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._clone23373)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify23374;
		protected abstract void engineInitVerify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineInitSign23375;
		protected virtual void engineInitSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineInitSign23375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineInitSign23375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign23376;
		protected abstract void engineInitSign(java.security.PrivateKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineSign23377;
		protected abstract byte[] engineSign();
		internal static global::MonoJavaBridge.MethodId _engineSign23378;
		protected virtual int engineSign(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.SignatureSpi._engineSign23378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineSign23378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify23379;
		protected abstract bool engineVerify(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineVerify23380;
		protected virtual bool engineVerify(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi._engineVerify23380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineVerify23380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23381;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate23382;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineUpdate23382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineUpdate23382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23383;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23384;
		protected virtual void engineSetParameter(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineSetParameter23384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineSetParameter23384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23385;
		protected abstract void engineSetParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameters23386;
		protected virtual global::java.security.AlgorithmParameters engineGetParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi._engineGetParameters23386)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineGetParameters23386)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter23387;
		protected abstract global::java.lang.Object engineGetParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _SignatureSpi23388;
		public SignatureSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._SignatureSpi23388);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
			global::java.security.SignatureSpi._clone23373 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.SignatureSpi._engineInitVerify23374 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.SignatureSpi._engineInitSign23375 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V");
			global::java.security.SignatureSpi._engineInitSign23376 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.SignatureSpi._engineSign23377 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSign", "()[B");
			global::java.security.SignatureSpi._engineSign23378 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSign", "([BII)I");
			global::java.security.SignatureSpi._engineVerify23379 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineVerify", "([B)Z");
			global::java.security.SignatureSpi._engineVerify23380 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineVerify", "([BII)Z");
			global::java.security.SignatureSpi._engineUpdate23381 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "(B)V");
			global::java.security.SignatureSpi._engineUpdate23382 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.SignatureSpi._engineUpdate23383 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "([BII)V");
			global::java.security.SignatureSpi._engineSetParameter23384 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.SignatureSpi._engineSetParameter23385 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.SignatureSpi._engineGetParameters23386 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.SignatureSpi._engineGetParameter23387 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.security.SignatureSpi._SignatureSpi23388 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.SignatureSpi))]
	internal sealed partial class SignatureSpi_ : java.security.SignatureSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SignatureSpi_()
		{
			InitJNI();
		}
		internal SignatureSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify23389;
		protected override void engineInitVerify(java.security.PublicKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineInitVerify23389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineInitVerify23389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign23390;
		protected override void engineInitSign(java.security.PrivateKey arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineInitSign23390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineInitSign23390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSign23391;
		protected override byte[] engineSign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineSign23391)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineSign23391)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify23392;
		protected override bool engineVerify(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineVerify23392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineVerify23392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23393;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineUpdate23393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineUpdate23393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23394;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineUpdate23394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineUpdate23394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23395;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineSetParameter23395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineSetParameter23395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter23396;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineGetParameter23396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineGetParameter23396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
			global::java.security.SignatureSpi_._engineInitVerify23389 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.SignatureSpi_._engineInitSign23390 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.SignatureSpi_._engineSign23391 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineSign", "()[B");
			global::java.security.SignatureSpi_._engineVerify23392 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineVerify", "([B)Z");
			global::java.security.SignatureSpi_._engineUpdate23393 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineUpdate", "(B)V");
			global::java.security.SignatureSpi_._engineUpdate23394 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.SignatureSpi_._engineSetParameter23395 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.SignatureSpi_._engineGetParameter23396 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
