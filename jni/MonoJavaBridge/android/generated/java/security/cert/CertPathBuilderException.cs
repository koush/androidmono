namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathBuilderException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertPathBuilderException()
		{
			InitJNI();
		}
		protected CertPathBuilderException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertPathBuilderException23503;
		public CertPathBuilderException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._CertPathBuilderException23503);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathBuilderException23504;
		public CertPathBuilderException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._CertPathBuilderException23504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathBuilderException23505;
		public CertPathBuilderException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._CertPathBuilderException23505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertPathBuilderException23506;
		public CertPathBuilderException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._CertPathBuilderException23506, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderException"));
			global::java.security.cert.CertPathBuilderException._CertPathBuilderException23503 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "()V");
			global::java.security.cert.CertPathBuilderException._CertPathBuilderException23504 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertPathBuilderException._CertPathBuilderException23505 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.security.cert.CertPathBuilderException._CertPathBuilderException23506 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
