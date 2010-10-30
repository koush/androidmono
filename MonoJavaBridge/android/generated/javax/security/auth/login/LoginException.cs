namespace javax.security.auth.login
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LoginException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LoginException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public LoginException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.login.LoginException._m0.native == global::System.IntPtr.Zero)
				global::javax.security.auth.login.LoginException._m0 = @__env.GetMethodIDNoThrow(global::javax.security.auth.login.LoginException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.login.LoginException.staticClass, global::javax.security.auth.login.LoginException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public LoginException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.login.LoginException._m1.native == global::System.IntPtr.Zero)
				global::javax.security.auth.login.LoginException._m1 = @__env.GetMethodIDNoThrow(global::javax.security.auth.login.LoginException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.login.LoginException.staticClass, global::javax.security.auth.login.LoginException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LoginException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.login.LoginException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/login/LoginException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
