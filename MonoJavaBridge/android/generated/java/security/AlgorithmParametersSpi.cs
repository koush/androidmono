namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.AlgorithmParametersSpi_))]
	public abstract partial class AlgorithmParametersSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParametersSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected abstract void engineInit(java.security.spec.AlgorithmParameterSpec arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		protected abstract void engineInit(byte[] arg0);
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void engineInit(byte[] arg0, java.lang.String arg1);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0);
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract byte[] engineGetEncoded();
		private static global::MonoJavaBridge.MethodId _m5;
		protected abstract byte[] engineGetEncoded(java.lang.String arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract global::java.lang.String engineToString();
		private static global::MonoJavaBridge.MethodId _m7;
		public AlgorithmParametersSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParametersSpi._m7.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParametersSpi._m7 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParametersSpi.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParametersSpi.staticClass, global::java.security.AlgorithmParametersSpi._m7);
			Init(@__env, handle);
		}
		static AlgorithmParametersSpi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.AlgorithmParametersSpi))]
	internal sealed partial class AlgorithmParametersSpi_ : java.security.AlgorithmParametersSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AlgorithmParametersSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void engineInit(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.AlgorithmParametersSpi_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void engineInit(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([B)V", ref global::java.security.AlgorithmParametersSpi_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void engineInit(byte[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineInit", "([BLjava/lang/String;)V", ref global::java.security.AlgorithmParametersSpi_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected override global::java.security.spec.AlgorithmParameterSpec engineGetParameterSpec(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", ref global::java.security.AlgorithmParametersSpi_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.spec.AlgorithmParameterSpec;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override byte[] engineGetEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "()[B", ref global::java.security.AlgorithmParametersSpi_._m4) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override byte[] engineGetEncoded(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineGetEncoded", "(Ljava/lang/String;)[B", ref global::java.security.AlgorithmParametersSpi_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override global::java.lang.String engineToString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AlgorithmParametersSpi_.staticClass, "engineToString", "()Ljava/lang/String;", ref global::java.security.AlgorithmParametersSpi_._m6) as java.lang.String;
		}
		static AlgorithmParametersSpi_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParametersSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParametersSpi"));
		}
	}
}
