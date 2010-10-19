namespace java.security.cert
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CertStoreException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CertStoreException()
		{
			InitJNI();
		}
		protected CertStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException17824;
		public CertStoreException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException17824);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException17825;
		public CertStoreException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException17825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException17826;
		public CertStoreException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException17826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CertStoreException17827;
		public CertStoreException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.cert.CertStoreException.staticClass, global::java.security.cert.CertStoreException._CertStoreException17827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.cert.CertStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/cert/CertStoreException"));
			global::java.security.cert.CertStoreException._CertStoreException17824 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "()V");
			global::java.security.cert.CertStoreException._CertStoreException17825 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.cert.CertStoreException._CertStoreException17826 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::java.security.cert.CertStoreException._CertStoreException17827 = @__env.GetMethodIDNoThrow(global::java.security.cert.CertStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
		}
	}
}
