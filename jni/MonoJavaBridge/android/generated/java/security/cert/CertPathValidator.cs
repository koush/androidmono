namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathValidator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathValidator()
		{
			InitJNI();
		}
		protected CertPathValidator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23512;
		public static global::java.security.cert.CertPathValidator getInstance(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getInstance23512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23513;
		public static global::java.security.cert.CertPathValidator getInstance(java.lang.String arg0, java.security.Provider arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getInstance23513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidator;
		}
		internal static global::MonoJavaBridge.MethodId _getInstance23514;
		public static global::java.security.cert.CertPathValidator getInstance(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getInstance23514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.cert.CertPathValidator;
		}
		public new global::java.lang.String Algorithm
		{
			get
			{
				return getAlgorithm();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlgorithm23515;
		public virtual global::java.lang.String getAlgorithm() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidator._getAlgorithm23515)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getAlgorithm23515)) as java.lang.String;
		}
		public new global::java.security.Provider Provider
		{
			get
			{
				return getProvider();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProvider23516;
		public virtual global::java.security.Provider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidator._getProvider23516)) as java.security.Provider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getProvider23516)) as java.security.Provider;
		}
		internal static global::MonoJavaBridge.MethodId _validate23517;
		public virtual global::java.security.cert.CertPathValidatorResult validate(java.security.cert.CertPath arg0, java.security.cert.CertPathParameters arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathValidatorResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidator._validate23517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidatorResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathValidatorResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._validate23517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidatorResult;
		}
		public static global::java.lang.String DefaultType
		{
			get
			{
				return getDefaultType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultType23518;
		public static global::java.lang.String getDefaultType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._getDefaultType23518)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidator23519;
		protected CertPathValidator(java.security.cert.CertPathValidatorSpi arg0, java.security.Provider arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidator.staticClass, global::java.security.cert.CertPathValidator._CertPathValidator23519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidator.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidator"));
			global::java.security.cert.CertPathValidator._getInstance23512 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/cert/CertPathValidator;");
			global::java.security.cert.CertPathValidator._getInstance23513 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getInstance", "(Ljava/lang/String;Ljava/security/Provider;)Ljava/security/cert/CertPathValidator;");
			global::java.security.cert.CertPathValidator._getInstance23514 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getInstance", "(Ljava/lang/String;)Ljava/security/cert/CertPathValidator;");
			global::java.security.cert.CertPathValidator._getAlgorithm23515 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getAlgorithm", "()Ljava/lang/String;");
			global::java.security.cert.CertPathValidator._getProvider23516 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getProvider", "()Ljava/security/Provider;");
			global::java.security.cert.CertPathValidator._validate23517 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "validate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathValidatorResult;");
			global::java.security.cert.CertPathValidator._getDefaultType23518 = @__env.GetStaticMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "getDefaultType", "()Ljava/lang/String;");
			global::java.security.cert.CertPathValidator._CertPathValidator23519 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidator.staticClass, "<init>", "(Ljava/security/cert/CertPathValidatorSpi;Ljava/security/Provider;Ljava/lang/String;)V");
		}
	}
}
