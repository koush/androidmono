namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathValidator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPathValidator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23513;
		public static global::java.security.cert.CertPathValidator getInstance(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidator._getInstance23513.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidator._getInstance23513 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathValidator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getInstance23513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23514;
		public static global::java.security.cert.CertPathValidator getInstance(java.lang.String arg0, java.security.Provider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidator._getInstance23514.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidator._getInstance23514 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathValidator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getInstance23514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23515;
		public static global::java.security.cert.CertPathValidator getInstance(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidator._getInstance23515.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidator._getInstance23515 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathValidator;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getInstance23515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathValidator;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23516;
		public virtual global::java.lang.String getAlgorithm()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.cert.CertPathValidator.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.cert.CertPathValidator._getAlgorithm23516) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23517;
		public virtual global::java.security.Provider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathValidator.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.cert.CertPathValidator._getProvider23517) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _validate23518;
		public virtual global::java.security.cert.CertPathValidatorResult validate(java.security.cert.CertPath arg0, java.security.cert.CertPathParameters arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.security.cert.CertPathValidatorResult>(this, global::java.security.cert.CertPathValidator.staticClass, "validate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathValidatorResult;", ref global::java.security.cert.CertPathValidator._validate23518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.cert.CertPathValidatorResult;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType23519;
		public static global::java.lang.String getDefaultType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidator._getDefaultType23519.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidator._getDefaultType23519 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getDefaultType", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getDefaultType23519)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidator23520;
		protected CertPathValidator(java.security.cert.CertPathValidatorSpi arg0, java.security.Provider arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidator._CertPathValidator23520.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidator._CertPathValidator23520 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "<init>", "(Ljava/security/cert/CertPathValidatorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._CertPathValidator23520, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static CertPathValidator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
