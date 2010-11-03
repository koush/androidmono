namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PSSParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PSSParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String DigestAlgorithm
		{
			get
			{
				return getDigestAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getDigestAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.PSSParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;", ref global::java.security.spec.PSSParameterSpec._m0) as java.lang.String;
		}
		public new global::java.lang.String MGFAlgorithm
		{
			get
			{
				return getMGFAlgorithm();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getMGFAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.PSSParameterSpec.staticClass, "getMGFAlgorithm", "()Ljava/lang/String;", ref global::java.security.spec.PSSParameterSpec._m1) as java.lang.String;
		}
		public new global::java.security.spec.AlgorithmParameterSpec MGFParameters
		{
			get
			{
				return getMGFParameters();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.security.spec.AlgorithmParameterSpec getMGFParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.spec.AlgorithmParameterSpec>(this, global::java.security.spec.PSSParameterSpec.staticClass, "getMGFParameters", "()Ljava/security/spec/AlgorithmParameterSpec;", ref global::java.security.spec.PSSParameterSpec._m2) as java.security.spec.AlgorithmParameterSpec;
		}
		public new int SaltLength
		{
			get
			{
				return getSaltLength();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getSaltLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.PSSParameterSpec.staticClass, "getSaltLength", "()I", ref global::java.security.spec.PSSParameterSpec._m3);
		}
		public new int TrailerField
		{
			get
			{
				return getTrailerField();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getTrailerField()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.PSSParameterSpec.staticClass, "getTrailerField", "()I", ref global::java.security.spec.PSSParameterSpec._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public PSSParameterSpec(java.lang.String arg0, java.lang.String arg1, java.security.spec.AlgorithmParameterSpec arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.PSSParameterSpec._m5.native == global::System.IntPtr.Zero)
				global::java.security.spec.PSSParameterSpec._m5 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/spec/AlgorithmParameterSpec;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public PSSParameterSpec(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.PSSParameterSpec._m6.native == global::System.IntPtr.Zero)
				global::java.security.spec.PSSParameterSpec._m6 = @__env.GetMethodIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.PSSParameterSpec.staticClass, global::java.security.spec.PSSParameterSpec._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT6541;
		public static global::java.security.spec.PSSParameterSpec DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.PSSParameterSpec.staticClass, _DEFAULT6541)) as java.security.spec.PSSParameterSpec;
			}
		}
		static PSSParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.PSSParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/PSSParameterSpec"));
			global::java.security.spec.PSSParameterSpec._DEFAULT6541 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.PSSParameterSpec.staticClass, "DEFAULT", "Ljava/security/spec/PSSParameterSpec;");
		}
	}
}
