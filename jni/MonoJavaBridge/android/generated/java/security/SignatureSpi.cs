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
		internal static global::MonoJavaBridge.MethodId _clone23255;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi._clone23255)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._clone23255)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify23256;
		protected abstract void engineInitVerify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineInitSign23257;
		protected virtual void engineInitSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineInitSign23257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineInitSign23257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign23258;
		protected abstract void engineInitSign(java.security.PrivateKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineSign23259;
		protected abstract byte[] engineSign();
		internal static global::MonoJavaBridge.MethodId _engineSign23260;
		protected virtual int engineSign(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.SignatureSpi._engineSign23260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineSign23260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify23261;
		protected abstract bool engineVerify(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineVerify23262;
		protected virtual bool engineVerify(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi._engineVerify23262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineVerify23262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23263;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate23264;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineUpdate23264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineUpdate23264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23265;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23266;
		protected virtual void engineSetParameter(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineSetParameter23266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineSetParameter23266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23267;
		protected abstract void engineSetParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameters23268;
		protected virtual global::java.security.AlgorithmParameters engineGetParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi._engineGetParameters23268)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineGetParameters23268)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter23269;
		protected abstract global::java.lang.Object engineGetParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _SignatureSpi23270;
		public SignatureSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._SignatureSpi23270);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
			global::java.security.SignatureSpi._clone23255 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.SignatureSpi._engineInitVerify23256 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.SignatureSpi._engineInitSign23257 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V");
			global::java.security.SignatureSpi._engineInitSign23258 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.SignatureSpi._engineSign23259 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSign", "()[B");
			global::java.security.SignatureSpi._engineSign23260 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSign", "([BII)I");
			global::java.security.SignatureSpi._engineVerify23261 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineVerify", "([B)Z");
			global::java.security.SignatureSpi._engineVerify23262 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineVerify", "([BII)Z");
			global::java.security.SignatureSpi._engineUpdate23263 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "(B)V");
			global::java.security.SignatureSpi._engineUpdate23264 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.SignatureSpi._engineUpdate23265 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "([BII)V");
			global::java.security.SignatureSpi._engineSetParameter23266 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.SignatureSpi._engineSetParameter23267 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.SignatureSpi._engineGetParameters23268 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.SignatureSpi._engineGetParameter23269 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.security.SignatureSpi._SignatureSpi23270 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.SignatureSpi))]
	public sealed partial class SignatureSpi_ : java.security.SignatureSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SignatureSpi_()
		{
			InitJNI();
		}
		internal SignatureSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify23271;
		protected override void engineInitVerify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineInitVerify23271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineInitVerify23271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign23272;
		protected override void engineInitSign(java.security.PrivateKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineInitSign23272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineInitSign23272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSign23273;
		protected override byte[] engineSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineSign23273)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineSign23273)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify23274;
		protected override bool engineVerify(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineVerify23274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineVerify23274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23275;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineUpdate23275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineUpdate23275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate23276;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineUpdate23276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineUpdate23276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter23277;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineSetParameter23277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineSetParameter23277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter23278;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineGetParameter23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineGetParameter23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
			global::java.security.SignatureSpi_._engineInitVerify23271 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.SignatureSpi_._engineInitSign23272 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.SignatureSpi_._engineSign23273 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineSign", "()[B");
			global::java.security.SignatureSpi_._engineVerify23274 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineVerify", "([B)Z");
			global::java.security.SignatureSpi_._engineUpdate23275 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineUpdate", "(B)V");
			global::java.security.SignatureSpi_._engineUpdate23276 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.SignatureSpi_._engineSetParameter23277 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.SignatureSpi_._engineGetParameter23278 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
