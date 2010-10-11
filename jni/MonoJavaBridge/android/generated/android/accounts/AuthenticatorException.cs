namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AuthenticatorException : android.accounts.AccountsException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthenticatorException()
		{
			InitJNI();
		}
		protected AuthenticatorException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorException124;
		public AuthenticatorException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorException.staticClass, global::android.accounts.AuthenticatorException._AuthenticatorException124);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorException125;
		public AuthenticatorException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorException.staticClass, global::android.accounts.AuthenticatorException._AuthenticatorException125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorException126;
		public AuthenticatorException(java.lang.String arg0, java.lang.Throwable arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorException.staticClass, global::android.accounts.AuthenticatorException._AuthenticatorException126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthenticatorException127;
		public AuthenticatorException(java.lang.Throwable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AuthenticatorException.staticClass, global::android.accounts.AuthenticatorException._AuthenticatorException127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AuthenticatorException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AuthenticatorException"));
			global::android.accounts.AuthenticatorException._AuthenticatorException124 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorException.staticClass, "<init>", "()V");
			global::android.accounts.AuthenticatorException._AuthenticatorException125 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::android.accounts.AuthenticatorException._AuthenticatorException126 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::android.accounts.AuthenticatorException._AuthenticatorException127 = @__env.GetMethodIDNoThrow(global::android.accounts.AuthenticatorException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
	}
}
