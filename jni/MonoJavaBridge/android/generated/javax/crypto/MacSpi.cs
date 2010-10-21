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
		internal static global::MonoJavaBridge.MethodId _clone28571;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi._clone28571)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._clone28571)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28572;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28573;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28574;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28575;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi._engineUpdate28575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._engineUpdate28575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset28576;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28577;
		protected abstract byte[] engineDoFinal();
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength28578;
		protected abstract int engineGetMacLength();
		internal static global::MonoJavaBridge.MethodId _MacSpi28579;
		public MacSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._MacSpi28579);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi._clone28571 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.crypto.MacSpi._engineInit28572 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi._engineUpdate28573 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi._engineUpdate28574 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi._engineUpdate28575 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::javax.crypto.MacSpi._engineReset28576 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi._engineDoFinal28577 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi._engineGetMacLength28578 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineGetMacLength", "()I");
			global::javax.crypto.MacSpi._MacSpi28579 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineInit28580;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineInit28580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineInit28580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28581;
		protected override void engineUpdate(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate28581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineUpdate28581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28582;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate28582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineUpdate28582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset28583;
		protected override void engineReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineReset28583);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineReset28583);
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28584;
		protected override byte[] engineDoFinal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineDoFinal28584)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineDoFinal28584)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength28585;
		protected override int engineGetMacLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineGetMacLength28585);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_.staticClass, global::javax.crypto.MacSpi_._engineGetMacLength28585);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi_._engineInit28580 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi_._engineUpdate28581 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi_._engineUpdate28582 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi_._engineReset28583 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi_._engineDoFinal28584 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi_._engineGetMacLength28585 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineGetMacLength", "()I");
		}
	}
}
