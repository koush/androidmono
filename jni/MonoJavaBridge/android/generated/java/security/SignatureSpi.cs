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
		internal static global::MonoJavaBridge.MethodId _clone17654;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi._clone17654)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._clone17654)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInitVerify17655;
		protected abstract void engineInitVerify(java.security.PublicKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineInitSign17656;
		protected virtual void engineInitSign(java.security.PrivateKey arg0, java.security.SecureRandom arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineInitSign17656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineInitSign17656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign17657;
		protected abstract void engineInitSign(java.security.PrivateKey arg0);
		internal static global::MonoJavaBridge.MethodId _engineSign17658;
		protected abstract byte[] engineSign();
		internal static global::MonoJavaBridge.MethodId _engineSign17659;
		protected virtual int engineSign(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.SignatureSpi._engineSign17659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineSign17659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify17660;
		protected abstract bool engineVerify(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineVerify17661;
		protected virtual bool engineVerify(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi._engineVerify17661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineVerify17661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17662;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate17663;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineUpdate17663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineUpdate17663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17664;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineSetParameter17665;
		protected virtual void engineSetParameter(java.security.spec.AlgorithmParameterSpec arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi._engineSetParameter17665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineSetParameter17665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter17666;
		protected abstract void engineSetParameter(java.lang.String arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameters17667;
		protected virtual global::java.security.AlgorithmParameters engineGetParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi._engineGetParameters17667)) as java.security.AlgorithmParameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._engineGetParameters17667)) as java.security.AlgorithmParameters;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter17668;
		protected abstract global::java.lang.Object engineGetParameter(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _SignatureSpi17669;
		public SignatureSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureSpi.staticClass, global::java.security.SignatureSpi._SignatureSpi17669);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
			global::java.security.SignatureSpi._clone17654 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.security.SignatureSpi._engineInitVerify17655 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.SignatureSpi._engineInitSign17656 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;Ljava/security/SecureRandom;)V");
			global::java.security.SignatureSpi._engineInitSign17657 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.SignatureSpi._engineSign17658 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSign", "()[B");
			global::java.security.SignatureSpi._engineSign17659 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSign", "([BII)I");
			global::java.security.SignatureSpi._engineVerify17660 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineVerify", "([B)Z");
			global::java.security.SignatureSpi._engineVerify17661 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineVerify", "([BII)Z");
			global::java.security.SignatureSpi._engineUpdate17662 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "(B)V");
			global::java.security.SignatureSpi._engineUpdate17663 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::java.security.SignatureSpi._engineUpdate17664 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineUpdate", "([BII)V");
			global::java.security.SignatureSpi._engineSetParameter17665 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::java.security.SignatureSpi._engineSetParameter17666 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.SignatureSpi._engineGetParameters17667 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineGetParameters", "()Ljava/security/AlgorithmParameters;");
			global::java.security.SignatureSpi._engineGetParameter17668 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.security.SignatureSpi._SignatureSpi17669 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineInitVerify17670;
		protected override void engineInitVerify(java.security.PublicKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineInitVerify17670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineInitVerify17670, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInitSign17671;
		protected override void engineInitSign(java.security.PrivateKey arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineInitSign17671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineInitSign17671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineSign17672;
		protected override byte[] engineSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineSign17672)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineSign17672)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineVerify17673;
		protected override bool engineVerify(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineVerify17673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineVerify17673, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17674;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineUpdate17674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineUpdate17674, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate17675;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineUpdate17675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineUpdate17675, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineSetParameter17676;
		protected override void engineSetParameter(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineSetParameter17676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineSetParameter17676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameter17677;
		protected override global::java.lang.Object engineGetParameter(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_._engineGetParameter17677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.SignatureSpi_.staticClass, global::java.security.SignatureSpi_._engineGetParameter17677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureSpi"));
			global::java.security.SignatureSpi_._engineInitVerify17670 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineInitVerify", "(Ljava/security/PublicKey;)V");
			global::java.security.SignatureSpi_._engineInitSign17671 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineInitSign", "(Ljava/security/PrivateKey;)V");
			global::java.security.SignatureSpi_._engineSign17672 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineSign", "()[B");
			global::java.security.SignatureSpi_._engineVerify17673 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineVerify", "([B)Z");
			global::java.security.SignatureSpi_._engineUpdate17674 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineUpdate", "(B)V");
			global::java.security.SignatureSpi_._engineUpdate17675 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineUpdate", "([BII)V");
			global::java.security.SignatureSpi_._engineSetParameter17676 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineSetParameter", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::java.security.SignatureSpi_._engineGetParameter17677 = @__env.GetMethodIDNoThrow(global::java.security.SignatureSpi_.staticClass, "engineGetParameter", "(Ljava/lang/String;)Ljava/lang/Object;");
		}
	}
}
