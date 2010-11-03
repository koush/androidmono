namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlgorithmParameterGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParameterGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameterGenerator._m0.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameterGenerator._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameterGenerator._m1.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameterGenerator._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameterGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.AlgorithmParameterGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.AlgorithmParameterGenerator getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameterGenerator._m2.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameterGenerator._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameterGenerator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameterGenerator;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.AlgorithmParameterGenerator._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;Ljava/security/SecureRandom;)V", ref global::java.security.AlgorithmParameterGenerator._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void init(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(I)V", ref global::java.security.AlgorithmParameterGenerator._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void init(int arg0, java.security.SecureRandom arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameterGenerator.staticClass, "init", "(ILjava/security/SecureRandom;)V", ref global::java.security.AlgorithmParameterGenerator._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AlgorithmParameterGenerator.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.AlgorithmParameterGenerator._m7) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AlgorithmParameterGenerator.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.AlgorithmParameterGenerator._m8) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.security.AlgorithmParameters generateParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AlgorithmParameterGenerator.staticClass, "generateParameters", "()Ljava/security/AlgorithmParameters;", ref global::java.security.AlgorithmParameterGenerator._m9) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected AlgorithmParameterGenerator(java.security.AlgorithmParameterGeneratorSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameterGenerator._m10.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameterGenerator._m10 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameterGenerator.staticClass, "<init>", "(Ljava/security/AlgorithmParameterGeneratorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameterGenerator.staticClass, global::java.security.AlgorithmParameterGenerator._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AlgorithmParameterGenerator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameterGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameterGenerator"));
		}
	}
}
