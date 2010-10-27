namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.cert.CertPathValidatorSpi_))]
	public abstract partial class CertPathValidatorSpi : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathValidatorSpi()
		{
			InitJNI();
		}
		protected CertPathValidatorSpi(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineValidate23528;
		public abstract global::java.security.cert.CertPathValidatorResult engineValidate(java.security.cert.CertPath arg0, java.security.cert.CertPathParameters arg1);
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorSpi23529;
		public CertPathValidatorSpi() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorSpi.staticClass, global::java.security.cert.CertPathValidatorSpi._CertPathValidatorSpi23529);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorSpi.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorSpi"));
			global::java.security.cert.CertPathValidatorSpi._engineValidate23528 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorSpi.staticClass, "engineValidate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathValidatorResult;");
			global::java.security.cert.CertPathValidatorSpi._CertPathValidatorSpi23529 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorSpi.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.cert.CertPathValidatorSpi))]
	internal sealed partial class CertPathValidatorSpi_ : java.security.cert.CertPathValidatorSpi
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathValidatorSpi_()
		{
			InitJNI();
		}
		internal CertPathValidatorSpi_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _engineValidate23530;
		public override global::java.security.cert.CertPathValidatorResult engineValidate(java.security.cert.CertPath arg0, java.security.cert.CertPathParameters arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathValidatorResult>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorSpi_._engineValidate23530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidatorResult;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.security.cert.CertPathValidatorResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorSpi_.staticClass, global::java.security.cert.CertPathValidatorSpi_._engineValidate23530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.cert.CertPathValidatorResult;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorSpi_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorSpi"));
			global::java.security.cert.CertPathValidatorSpi_._engineValidate23530 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorSpi_.staticClass, "engineValidate", "(Ljava/security/cert/CertPath;Ljava/security/cert/CertPathParameters;)Ljava/security/cert/CertPathValidatorResult;");
		}
	}
}
