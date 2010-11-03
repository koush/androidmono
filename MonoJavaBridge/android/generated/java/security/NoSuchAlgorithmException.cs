namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchAlgorithmException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchAlgorithmException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoSuchAlgorithmException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.NoSuchAlgorithmException._m0.native == global::System.IntPtr.Zero)
				global::java.security.NoSuchAlgorithmException._m0 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoSuchAlgorithmException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.NoSuchAlgorithmException._m1.native == global::System.IntPtr.Zero)
				global::java.security.NoSuchAlgorithmException._m1 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public NoSuchAlgorithmException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.NoSuchAlgorithmException._m2.native == global::System.IntPtr.Zero)
				global::java.security.NoSuchAlgorithmException._m2 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public NoSuchAlgorithmException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.NoSuchAlgorithmException._m3.native == global::System.IntPtr.Zero)
				global::java.security.NoSuchAlgorithmException._m3 = @__env.GetMethodIDNoThrow(global::java.security.NoSuchAlgorithmException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.NoSuchAlgorithmException.staticClass, global::java.security.NoSuchAlgorithmException._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchAlgorithmException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.NoSuchAlgorithmException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/NoSuchAlgorithmException"));
		}
	}
}
