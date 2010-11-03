namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MGF1ParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MGF1ParameterSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.spec.MGF1ParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;", ref global::java.security.spec.MGF1ParameterSpec._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public MGF1ParameterSpec(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.MGF1ParameterSpec._m1.native == global::System.IntPtr.Zero)
				global::java.security.spec.MGF1ParameterSpec._m1 = @__env.GetMethodIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.MGF1ParameterSpec.staticClass, global::java.security.spec.MGF1ParameterSpec._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _SHA16537;
		public static global::java.security.spec.MGF1ParameterSpec SHA1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA16537)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA2566538;
		public static global::java.security.spec.MGF1ParameterSpec SHA256
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA2566538)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA3846539;
		public static global::java.security.spec.MGF1ParameterSpec SHA384
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA3846539)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA5126540;
		public static global::java.security.spec.MGF1ParameterSpec SHA512
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA5126540)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		static MGF1ParameterSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.MGF1ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/MGF1ParameterSpec"));
			global::java.security.spec.MGF1ParameterSpec._SHA16537 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA1", "Ljava/security/spec/MGF1ParameterSpec;");
			global::java.security.spec.MGF1ParameterSpec._SHA2566538 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA256", "Ljava/security/spec/MGF1ParameterSpec;");
			global::java.security.spec.MGF1ParameterSpec._SHA3846539 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA384", "Ljava/security/spec/MGF1ParameterSpec;");
			global::java.security.spec.MGF1ParameterSpec._SHA5126540 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA512", "Ljava/security/spec/MGF1ParameterSpec;");
		}
	}
}
