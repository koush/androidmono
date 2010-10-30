namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GeneralSecurityException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GeneralSecurityException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public GeneralSecurityException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.GeneralSecurityException._m0.native == global::System.IntPtr.Zero)
				global::java.security.GeneralSecurityException._m0 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public GeneralSecurityException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.GeneralSecurityException._m1.native == global::System.IntPtr.Zero)
				global::java.security.GeneralSecurityException._m1 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public GeneralSecurityException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.GeneralSecurityException._m2.native == global::System.IntPtr.Zero)
				global::java.security.GeneralSecurityException._m2 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public GeneralSecurityException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.GeneralSecurityException._m3.native == global::System.IntPtr.Zero)
				global::java.security.GeneralSecurityException._m3 = @__env.GetMethodIDNoThrow(global::java.security.GeneralSecurityException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.GeneralSecurityException.staticClass, global::java.security.GeneralSecurityException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static GeneralSecurityException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.GeneralSecurityException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/GeneralSecurityException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
