namespace javax.security.auth.login
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LoginException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LoginException()
		{
			InitJNI();
		}
		protected LoginException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LoginException30207;
		public LoginException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.login.LoginException.staticClass, global::javax.security.auth.login.LoginException._LoginException30207);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LoginException30208;
		public LoginException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.login.LoginException.staticClass, global::javax.security.auth.login.LoginException._LoginException30208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.login.LoginException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/login/LoginException"));
			global::javax.security.auth.login.LoginException._LoginException30207 = @__env.GetMethodIDNoThrow(global::javax.security.auth.login.LoginException.staticClass, "<init>", "()V");
			global::javax.security.auth.login.LoginException._LoginException30208 = @__env.GetMethodIDNoThrow(global::javax.security.auth.login.LoginException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
