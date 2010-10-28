namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathValidatorException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathValidatorException()
		{
			InitJNI();
		}
		protected CertPathValidatorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex23521;
		public virtual int getIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException._getIndex23521);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._getIndex23521);
		}
		public new global::java.security.cert.CertPath CertPath
		{
			get
			{
				return getCertPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCertPath23522;
		public virtual global::java.security.cert.CertPath getCertPath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException._getCertPath23522)) as java.security.cert.CertPath;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._getCertPath23522)) as java.security.cert.CertPath;
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23523;
		public CertPathValidatorException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23523);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23524;
		public CertPathValidatorException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23524, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23525;
		public CertPathValidatorException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23526;
		public CertPathValidatorException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23526, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathValidatorException23527;
		public CertPathValidatorException(java.lang.String arg0, java.lang.Throwable arg1, java.security.cert.CertPath arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._CertPathValidatorException23527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorException"));
			global::java.security.cert.CertPathValidatorException._getIndex23521 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "getIndex", "()I");
			global::java.security.cert.CertPathValidatorException._getCertPath23522 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23523 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "()V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23524 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23525 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23526 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.cert.CertPathValidatorException._CertPathValidatorException23527 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/security/cert/CertPath;I)V");
		}
	}
}
