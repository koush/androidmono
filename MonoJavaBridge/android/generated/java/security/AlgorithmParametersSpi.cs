namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AlgorithmParametersSpi_))]
	public abstract partial class AlgorithmParametersSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParametersSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22876;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22877;
		protected abstract void engineInit(byte[] arg0);
		internal static global::MonoJavaBridge.MethodId _engineInit22878;
		protected abstract void engineInit(byte[] arg0, java.lang.String arg1);
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec22879;
		protected abstract global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0);
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22880;
		protected abstract byte[] engineGetEncoded();
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22881;
		protected abstract byte[] engineGetEncoded(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _engineToString22882;
		protected abstract global::java.lang.String engineToString();
		internal static global::MonoJavaBridge.MethodId _AlgorithmParametersSpi22883;
		public AlgorithmParametersSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22883.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22883 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParametersSpi.staticClass, global::java.security.AlgorithmParametersSpi._AlgorithmParametersSpi22883);
			Init(@__env, handle);
		}
		static AlgorithmParametersSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AlgorithmParametersSpi))]
	internal sealed partial class AlgorithmParametersSpi_ : java.security.AlgorithmParametersSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlgorithmParametersSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22884;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.AlgorithmParametersSpi_._engineInit22884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22885;
		protected override void engineInit(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([B)V", ref global::java.security.AlgorithmParametersSpi_._engineInit22885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _engineInit22886;
		protected override void engineInit(byte[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([BLjava/lang/String;)V", ref global::java.security.AlgorithmParametersSpi_._engineInit22886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _engineGetParameterSpec22887;
		protected override global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", ref global::java.security.AlgorithmParametersSpi_._engineGetParameterSpec22887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.spec.AlgorithmParameterSpec;
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22888;
		protected override byte[] engineGetEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "()[B", ref global::java.security.AlgorithmParametersSpi_._engineGetEncoded22888) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineGetEncoded22889;
		protected override byte[] engineGetEncoded(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B", ref global::java.security.AlgorithmParametersSpi_._engineGetEncoded22889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _engineToString22890;
		protected override global::java.lang.String engineToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineToString", "()Ljava/lang/String;", ref global::java.security.AlgorithmParametersSpi_._engineToString22890) as java.lang.String;
		}
		static AlgorithmParametersSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
		}
		internal static void InitJNI()
		{
		}
	}
}
