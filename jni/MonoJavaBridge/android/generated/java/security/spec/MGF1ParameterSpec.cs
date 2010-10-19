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
		internal static global::MonoJavaBridge.MethodId _getDigestAlgorithm18302;
		public virtual global::java.lang.String getDigestAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.spec.MGF1ParameterSpec._getDigestAlgorithm18302)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.spec.MGF1ParameterSpec.staticClass, global::java.security.spec.MGF1ParameterSpec._getDigestAlgorithm18302)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _MGF1ParameterSpec18303;
		public MGF1ParameterSpec(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.MGF1ParameterSpec.staticClass, global::java.security.spec.MGF1ParameterSpec._MGF1ParameterSpec18303, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _SHA118304;
		public static global::java.security.spec.MGF1ParameterSpec SHA1
		{
			get
			{
				return default(global::java.security.spec.MGF1ParameterSpec);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA25618305;
		public static global::java.security.spec.MGF1ParameterSpec SHA256
		{
			get
			{
				return default(global::java.security.spec.MGF1ParameterSpec);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA38418306;
		public static global::java.security.spec.MGF1ParameterSpec SHA384
		{
			get
			{
				return default(global::java.security.spec.MGF1ParameterSpec);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SHA51218307;
		public static global::java.security.spec.MGF1ParameterSpec SHA512
		{
			get
			{
				return default(global::java.security.spec.MGF1ParameterSpec);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.MGF1ParameterSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/MGF1ParameterSpec"));
			global::java.security.spec.MGF1ParameterSpec._getDigestAlgorithm18302 = @__env.GetMethodIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "getDigestAlgorithm", "()Ljava/lang/String;");
			global::java.security.spec.MGF1ParameterSpec._MGF1ParameterSpec18303 = @__env.GetMethodIDNoThrow(global::java.security.spec.MGF1ParameterSpec.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
