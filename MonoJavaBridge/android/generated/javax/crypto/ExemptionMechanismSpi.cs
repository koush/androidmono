namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.ExemptionMechanismSpi_))]
	public abstract partial class ExemptionMechanismSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ExemptionMechanismSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28609;
		protected abstract void engineInit(java.security.Key arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit28610;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		internal static global::MonoJavaBridge.MethodId _engineInit28611;
		protected abstract void engineInit(java.security.Key arg0, java.security.AlgorithmParameters arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize28612;
		protected abstract int engineGetOutputSize(int arg0);
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob28613;
		protected abstract byte[] engineGenExemptionBlob();
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob28614;
		protected abstract int engineGenExemptionBlob(byte[] arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _ExemptionMechanismSpi28615;
		public ExemptionMechanismSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi._ExemptionMechanismSpi28615.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi._ExemptionMechanismSpi28615 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.ExemptionMechanismSpi.staticClass, global::javax.crypto.ExemptionMechanismSpi._ExemptionMechanismSpi28615);
			Init(@__env, handle);
		}
		static ExemptionMechanismSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.ExemptionMechanismSpi))]
	internal sealed partial class ExemptionMechanismSpi_ : javax.crypto.ExemptionMechanismSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ExemptionMechanismSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28616;
		protected override void engineInit(java.security.Key arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi_._engineInit28616.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi_._engineInit28616 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineInit28616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28617;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi_._engineInit28617.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi_._engineInit28617 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineInit28617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28618;
		protected override void engineInit(java.security.Key arg0, java.security.AlgorithmParameters arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi_._engineInit28618.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi_._engineInit28618 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/AlgorithmParameters;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineInit28618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetOutputSize28619;
		protected override int engineGetOutputSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi_._engineGetOutputSize28619.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi_._engineGetOutputSize28619 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGetOutputSize", "(I)I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineGetOutputSize28619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob28620;
		protected override byte[] engineGenExemptionBlob()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob28620.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob28620 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGenExemptionBlob", "()[B");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob28620)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGenExemptionBlob28621;
		protected override int engineGenExemptionBlob(byte[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob28621.native == global::System.IntPtr.Zero)
				global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob28621 = @__env.GetMethodIDNoThrow(global::javax.crypto.ExemptionMechanismSpi_.staticClass, "engineGenExemptionBlob", "([BI)I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.ExemptionMechanismSpi_._engineGenExemptionBlob28621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static ExemptionMechanismSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.ExemptionMechanismSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/ExemptionMechanismSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
