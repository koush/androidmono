namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MGF1ParameterSpec : java.lang.Object, AlgorithmParameterSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MGF1ParameterSpec()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getDigestAlgorithm24030;
		public virtual global::java.lang.String getDigestAlgorithm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.MGF1ParameterSpec._getDigestAlgorithm24030)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.MGF1ParameterSpec.staticClass, global::java.security.spec.MGF1ParameterSpec._getDigestAlgorithm24030)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MGF1ParameterSpec24031;
		public MGF1ParameterSpec(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.MGF1ParameterSpec.staticClass, global::java.security.spec.MGF1ParameterSpec._MGF1ParameterSpec24031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _SHA124032;
		public static global::java.security.spec.MGF1ParameterSpec SHA1
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA124032)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA25624033;
		public static global::java.security.spec.MGF1ParameterSpec SHA256
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA25624033)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA38424034;
		public static global::java.security.spec.MGF1ParameterSpec SHA384
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA38424034)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA51224035;
		public static global::java.security.spec.MGF1ParameterSpec SHA512
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.spec.MGF1ParameterSpec.staticClass, _SHA51224035)) as java.security.spec.MGF1ParameterSpec;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.MGF1ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/MGF1ParameterSpec"));
			global::java.security.spec.MGF1ParameterSpec._getDigestAlgorithm24030 = @__env.GetMethodIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;");
			global::java.security.spec.MGF1ParameterSpec._MGF1ParameterSpec24031 = @__env.GetMethodIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.spec.MGF1ParameterSpec._SHA124032 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA1", "Ljava/security/spec/MGF1ParameterSpec;");
			global::java.security.spec.MGF1ParameterSpec._SHA25624033 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA256", "Ljava/security/spec/MGF1ParameterSpec;");
			global::java.security.spec.MGF1ParameterSpec._SHA38424034 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA384", "Ljava/security/spec/MGF1ParameterSpec;");
			global::java.security.spec.MGF1ParameterSpec._SHA51224035 = @__env.GetStaticFieldIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "SHA512", "Ljava/security/spec/MGF1ParameterSpec;");
		}
	}
}
