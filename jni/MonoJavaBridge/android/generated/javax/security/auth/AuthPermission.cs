namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AuthPermission()
		{
			InitJNI();
		}
		internal AuthPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AuthPermission30044;
		public AuthPermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.AuthPermission.staticClass, global::javax.security.auth.AuthPermission._AuthPermission30044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AuthPermission30045;
		public AuthPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.AuthPermission.staticClass, global::javax.security.auth.AuthPermission._AuthPermission30045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.AuthPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/AuthPermission"));
			global::javax.security.auth.AuthPermission._AuthPermission30044 = @__env.GetMethodIDNoThrow(global::javax.security.auth.AuthPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::javax.security.auth.AuthPermission._AuthPermission30045 = @__env.GetMethodIDNoThrow(global::javax.security.auth.AuthPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
