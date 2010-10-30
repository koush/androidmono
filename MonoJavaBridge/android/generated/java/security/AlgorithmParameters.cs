namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlgorithmParameters : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AlgorithmParameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AlgorithmParameters.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.AlgorithmParameters._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.AlgorithmParameters getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameters._m1.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameters._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/AlgorithmParameters;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.AlgorithmParameters getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameters._m2.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameters._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/AlgorithmParameters;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.security.AlgorithmParameters getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameters._m3.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameters._m3 = @__env.GetStaticMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/AlgorithmParameters;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.AlgorithmParameters;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void init(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameters.staticClass, "init", "([B)V", ref global::java.security.AlgorithmParameters._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void init(java.security.spec.AlgorithmParameterSpec arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameters.staticClass, "init", "(Ljava/security/spec/AlgorithmParameterSpec;)V", ref global::java.security.AlgorithmParameters._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void init(byte[] arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.AlgorithmParameters.staticClass, "init", "([BLjava/lang/String;)V", ref global::java.security.AlgorithmParameters._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new byte[] Encoded
		{
			get
			{
				return getEncoded();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual byte[] getEncoded()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.AlgorithmParameters.staticClass, "getEncoded", "()[B", ref global::java.security.AlgorithmParameters._m7) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual byte[] getEncoded(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.security.AlgorithmParameters.staticClass, "getEncoded", "(Ljava/lang/String;)[B", ref global::java.security.AlgorithmParameters._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.AlgorithmParameters.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.AlgorithmParameters._m9) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.AlgorithmParameters.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.AlgorithmParameters._m10) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.security.spec.AlgorithmParameterSpec getParameterSpec(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::java.security.AlgorithmParameters.staticClass, "getParameterSpec", "(Ljava/lang/Class;)Ljava/security/spec/AlgorithmParameterSpec;", ref global::java.security.AlgorithmParameters._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.spec.AlgorithmParameterSpec;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		protected AlgorithmParameters(java.security.AlgorithmParametersSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.AlgorithmParameters._m12.native == global::System.IntPtr.Zero)
				global::java.security.AlgorithmParameters._m12 = @__env.GetMethodIDNoThrow(global::java.security.AlgorithmParameters.staticClass, "<init>", "(Ljava/security/AlgorithmParametersSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.AlgorithmParameters.staticClass, global::java.security.AlgorithmParameters._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AlgorithmParameters()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.AlgorithmParameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/AlgorithmParameters"));
		}
		internal static void InitJNI()
		{
		}
	}
}
