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
		internal static global::MonoJavaBridge.MethodId _LoginException23658;
		public LoginException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.login.LoginException.staticClass, global::javax.security.auth.login.LoginException._LoginException23658);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LoginException23659;
		public LoginException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.login.LoginException.staticClass, global::javax.security.auth.login.LoginException._LoginException23659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.login.LoginException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/login/LoginException"));
			global::javax.security.auth.login.LoginException._LoginException23658 = @__env.GetMethodIDNoThrow(global::javax.security.auth.login.LoginException.staticClass, "<init>", "()V");
			global::javax.security.auth.login.LoginException._LoginException23659 = @__env.GetMethodIDNoThrow(global::javax.security.auth.login.LoginException.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
