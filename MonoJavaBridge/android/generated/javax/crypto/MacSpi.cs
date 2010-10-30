namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.MacSpi_))]
	public abstract partial class MacSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MacSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.MacSpi.staticClass, "clone", "()Ljava/lang/Object;", ref global::javax.crypto.MacSpi._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void engineUpdate(byte arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		private static global::MonoJavaBridge.MethodId _m4;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V", ref global::javax.crypto.MacSpi._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected abstract void engineReset();
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract byte[] engineDoFinal();
		private static global::MonoJavaBridge.MethodId _m7;
		protected abstract int engineGetMacLength();
		private static global::MonoJavaBridge.MethodId _m8;
		public MacSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.crypto.MacSpi._m8.native == global::System.IntPtr.Zero)
				global::javax.crypto.MacSpi._m8 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._m8);
			Init(@__env, handle);
		}
		static MacSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.crypto.MacSpi))]
	internal sealed partial class MacSpi_ : javax.crypto.MacSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal MacSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.MacSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::javax.crypto.MacSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "(B)V", ref global::javax.crypto.MacSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "([BII)V", ref global::javax.crypto.MacSpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override void engineReset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.MacSpi_.staticClass, "engineReset", "()V", ref global::javax.crypto.MacSpi_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override byte[] engineDoFinal()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.crypto.MacSpi_.staticClass, "engineDoFinal", "()[B", ref global::javax.crypto.MacSpi_._m4) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override int engineGetMacLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.crypto.MacSpi_.staticClass, "engineGetMacLength", "()I", ref global::javax.crypto.MacSpi_._m5);
		}
		static MacSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
