namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SignatureException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SignatureException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23370;
		public SignatureException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SignatureException._SignatureException23370.native == global::System.IntPtr.Zero)
				global::java.security.SignatureException._SignatureException23370 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23370);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23371;
		public SignatureException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SignatureException._SignatureException23371.native == global::System.IntPtr.Zero)
				global::java.security.SignatureException._SignatureException23371 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23372;
		public SignatureException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SignatureException._SignatureException23372.native == global::System.IntPtr.Zero)
				global::java.security.SignatureException._SignatureException23372 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SignatureException23373;
		public SignatureException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SignatureException._SignatureException23373.native == global::System.IntPtr.Zero)
				global::java.security.SignatureException._SignatureException23373 = @__env.GetMethodIDNoThrow(global::java.security.SignatureException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SignatureException.staticClass, global::java.security.SignatureException._SignatureException23373, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SignatureException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SignatureException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SignatureException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
