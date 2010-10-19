namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.ExemptionMechanismSpi_))]
	public abstract partial class ExemptionMechanismSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExemptionMechanismSpi()
		{
			InitJNI();
		}
		protected ExemptionMechanismSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22594;
		protected abstract void engineInit(java.security.Key arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22595;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		internal static global::MonoJavaBridge.MethodId _engineInit22596;
		protected abstract void engineInit(java.security.Key arg0, java.security.AlgorithmParameters arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize22597;
		protected abstract int engineGetOutputSize(int arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob22598;
		protected abstract byte[] engineGenExemptionBlob();
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob22599;
		protected abstract int engineGenExemptionBlob(byte[] arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanismSpi22600;
		public ExemptionMechanismSpi()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismSpi.staticClass, global::javax.crypto.ExemptionMechanismSpi._ExemptionMechanismSpi22600);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismSpi"));
			global::javax.crypto.ExemptionMechanismSpi._engineInit22594 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "engineInit", "(Ljava/security/Key;)V");
			global::javax.crypto.ExemptionMechanismSpi._engineInit22595 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.ExemptionMechanismSpi._engineInit22596 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.ExemptionMechanismSpi._engineGetOutputSize22597 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "engineGetOutputSize", "(I)I");
			global::javax.crypto.ExemptionMechanismSpi._engineGenExemptionBlob22598 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "engineGenExemptionBlob", "()[B");
			global::javax.crypto.ExemptionMechanismSpi._engineGenExemptionBlob22599 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "engineGenExemptionBlob", "([BI)I");
			global::javax.crypto.ExemptionMechanismSpi._ExemptionMechanismSpi22600 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.ExemptionMechanismSpi))]
	public sealed partial class ExemptionMechanismSpi_ : javax.crypto.ExemptionMechanismSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExemptionMechanismSpi_()
		{
			InitJNI();
		}
		internal ExemptionMechanismSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22601;
		protected override void engineInit(java.security.Key arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineInit22601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_.staticClass, global::javax.crypto.ExemptionMechanismSpi_._engineInit22601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22602;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineInit22602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_.staticClass, global::javax.crypto.ExemptionMechanismSpi_._engineInit22602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22603;
		protected override void engineInit(java.security.Key arg0, java.security.AlgorithmParameters arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineInit22603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_.staticClass, global::javax.crypto.ExemptionMechanismSpi_._engineInit22603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize22604;
		protected override int engineGetOutputSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineGetOutputSize22604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_.staticClass, global::javax.crypto.ExemptionMechanismSpi_._engineGetOutputSize22604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob22605;
		protected override byte[] engineGenExemptionBlob() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob22605)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_.staticClass, global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob22605)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob22606;
		protected override int engineGenExemptionBlob(byte[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob22606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_.staticClass, global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob22606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismSpi"));
			global::javax.crypto.ExemptionMechanismSpi_._engineInit22601 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;)V");
			global::javax.crypto.ExemptionMechanismSpi_._engineInit22602 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.ExemptionMechanismSpi_._engineInit22603 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V");
			global::javax.crypto.ExemptionMechanismSpi_._engineGetOutputSize22604 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGetOutputSize", "(I)I");
			global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob22605 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGenExemptionBlob", "()[B");
			global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob22606 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGenExemptionBlob", "([BI)I");
		}
	}
}
