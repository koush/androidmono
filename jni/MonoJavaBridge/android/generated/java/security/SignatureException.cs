namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SignatureException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SignatureException()
		{
			InitJNI();
		}
		protected SignatureException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23251;
		public SignatureException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23251);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23252;
		public SignatureException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23253;
		public SignatureException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23254;
		public SignatureException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureException"));
			global::java.security.SignatureException._SignatureException23251 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "()V");
			global::java.security.SignatureException._SignatureException23252 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.SignatureException._SignatureException23253 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.SignatureException._SignatureException23254 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
