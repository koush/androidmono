namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertPathValidatorException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.cert.CertPathValidatorException.staticClass, "getIndex", "()I", ref global::java.security.cert.CertPathValidatorException._m0);
		}
		public new global::java.security.cert.CertPath CertPath
		{
			get
			{
				return getCertPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.security.cert.CertPath getCertPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.cert.CertPathValidatorException.staticClass, "getCertPath", "()Ljava/security/cert/CertPath;", ref global::java.security.cert.CertPathValidatorException._m1) as java.security.cert.CertPath;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public CertPathValidatorException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidatorException._m2.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidatorException._m2 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._m2);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public CertPathValidatorException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidatorException._m3.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidatorException._m3 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public CertPathValidatorException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidatorException._m4.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidatorException._m4 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public CertPathValidatorException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidatorException._m5.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidatorException._m5 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public CertPathValidatorException(java.lang.String arg0, java.lang.Throwable arg1, java.security.cert.CertPath arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.cert.CertPathValidatorException._m6.native == global::System.IntPtr.Zero)
				global::java.security.cert.CertPathValidatorException._m6 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertPathValidatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;Ljava/security/cert/CertPath;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertPathValidatorException.staticClass, global::java.security.cert.CertPathValidatorException._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static CertPathValidatorException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertPathValidatorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertPathValidatorException"));
		}
	}
}
