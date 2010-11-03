namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathBuilderException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CertPathBuilderException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public CertPathBuilderException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilderException._m0.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilderException._m0 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public CertPathBuilderException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilderException._m1.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilderException._m1 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public CertPathBuilderException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilderException._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilderException._m2 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public CertPathBuilderException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathBuilderException._m3.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathBuilderException._m3 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathBuilderException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathBuilderException.staticClass, global::java.security.cert.CertPathBuilderException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CertPathBuilderException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathBuilderException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathBuilderException"));
		}
	}
}
