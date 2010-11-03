namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathBuilder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPathBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.security.cert.CertPathBuilder getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilder._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilder._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.security.cert.CertPathBuilder getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilder._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilder._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathBuilder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.security.cert.CertPathBuilder getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilder._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilder._m2 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathBuilder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathBuilder;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CertPathBuilder.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.cert.CertPathBuilder._m3) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathBuilder.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.cert.CertPathBuilder._m4) as java.security.Provider;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.security.cert.CertPathBuilderResult build(java.security.cert.CertPathParameters arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertPathBuilderResult>(this, global::java.security.cert.CertPathBuilder.staticClass, "build", "(Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathBuilderResult;", ref global::java.security.cert.CertPathBuilder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.security.cert.CertPathBuilderResult;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.lang.String getDefaultType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilder._m6.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilder._m6 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "getDefaultType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._m6)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected CertPathBuilder(java.security.cert.CertPathBuilderSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilder._m7.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilder._m7 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilder.staticClass, "<init>", "(Ljava/security/cert/CertPathBuilderSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilder.staticClass, global::java.security.cert.CertPathBuilder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CertPathBuilder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilder"));
		}
	}
}
