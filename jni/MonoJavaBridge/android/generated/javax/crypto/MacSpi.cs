namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.MacSpi_))]
	public abstract partial class MacSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MacSpi()
		{
			InitJNI();
		}
		protected MacSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone22675;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi._clone22675)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._clone22675)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22676;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		internal static global::MonoJavaBridge.MethodId _engineUpdate22677;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate22678;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate22679;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi._engineUpdate22679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._engineUpdate22679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset22680;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22681;
		protected abstract byte[] engineDoFinal();
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength22682;
		protected abstract int engineGetMacLength();
		internal static global::MonoJavaBridge.MethodId _MacSpi22683;
		public MacSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._MacSpi22683);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi._clone22675 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.crypto.MacSpi._engineInit22676 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi._engineUpdate22677 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi._engineUpdate22678 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi._engineUpdate22679 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::javax.crypto.MacSpi._engineReset22680 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi._engineDoFinal22681 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi._engineGetMacLength22682 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineGetMacLength", "()I");
			global::javax.crypto.MacSpi._MacSpi22683 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.MacSpi))]
	public sealed partial class MacSpi_ : javax.crypto.MacSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MacSpi_()
		{
			InitJNI();
		}
		internal MacSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22684;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineInit22684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineInit22684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate22685;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate22685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineUpdate22685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate22686;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate22686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineUpdate22686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset22687;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineReset22687);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineReset22687);
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal22688;
		protected override byte[] engineDoFinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineDoFinal22688)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineDoFinal22688)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength22689;
		protected override int engineGetMacLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineGetMacLength22689);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineGetMacLength22689);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi_._engineInit22684 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi_._engineUpdate22685 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi_._engineUpdate22686 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi_._engineReset22687 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi_._engineDoFinal22688 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi_._engineGetMacLength22689 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineGetMacLength", "()I");
		}
	}
}
