namespace javax.crypto
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.crypto.MacSpi_))]
	public abstract partial class MacSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MacSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone28690;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._clone28690)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _engineInit28691;
		protected abstract void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28692;
		protected abstract void engineUpdate(byte arg0);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28693;
		protected abstract void engineUpdate(byte[] arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _engineUpdate28694;
		protected virtual void engineUpdate(java.nio.ByteBuffer arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._engineUpdate28694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset28695;
		protected abstract void engineReset();
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28696;
		protected abstract byte[] engineDoFinal();
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength28697;
		protected abstract int engineGetMacLength();
		internal static global::MonoJavaBridge.MethodId _MacSpi28698;
		public MacSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.crypto.MacSpi.staticClass, global::javax.crypto.MacSpi._MacSpi28698);
			Init(@__env, handle);
		}
		static MacSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi._clone28690 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.crypto.MacSpi._engineInit28691 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi._engineUpdate28692 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi._engineUpdate28693 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi._engineUpdate28694 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineUpdate", "(Ljava/nio/ByteBuffer;)V");
			global::javax.crypto.MacSpi._engineReset28695 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi._engineDoFinal28696 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi._engineGetMacLength28697 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "engineGetMacLength", "()I");
			global::javax.crypto.MacSpi._MacSpi28698 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _engineInit28699;
		protected override void engineInit(java.security.Key arg0, java.security.spec.AlgorithmParameterSpec arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineInit28699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28700;
		protected override void engineUpdate(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate28700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineUpdate28701;
		protected override void engineUpdate(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineUpdate28701, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _engineReset28702;
		protected override void engineReset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallVoidMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineReset28702);
		}
		internal static global::MonoJavaBridge.MethodId _engineDoFinal28703;
		protected override byte[] engineDoFinal()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineDoFinal28703)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetMacLength28704;
		protected override int engineGetMacLength()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::javax.crypto.MacSpi_._engineGetMacLength28704);
		}
		static MacSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.crypto.MacSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/crypto/MacSpi"));
			global::javax.crypto.MacSpi_._engineInit28699 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineInit", "(Ljava/security/Key;Ljava/security/spec/AlgorithmParameterSpec;)V");
			global::javax.crypto.MacSpi_._engineUpdate28700 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "(B)V");
			global::javax.crypto.MacSpi_._engineUpdate28701 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineUpdate", "([BII)V");
			global::javax.crypto.MacSpi_._engineReset28702 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineReset", "()V");
			global::javax.crypto.MacSpi_._engineDoFinal28703 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineDoFinal", "()[B");
			global::javax.crypto.MacSpi_._engineGetMacLength28704 = @__env.GetMethodIDNoThrow(global::javax.crypto.MacSpi_.staticClass, "engineGetMacLength", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}
