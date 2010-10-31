namespace javax.security.auth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AuthPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AuthPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AuthPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.AuthPermission._m0.native == global::System.IntPtr.Zero)
				global::javax.security.auth.AuthPermission._m0 = @__env.GetMethodIDNoThrow(global::javax.security.auth.AuthPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.AuthPermission.staticClass, global::javax.security.auth.AuthPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AuthPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.security.auth.AuthPermission._m1.native == global::System.IntPtr.Zero)
				global::javax.security.auth.AuthPermission._m1 = @__env.GetMethodIDNoThrow(global::javax.security.auth.AuthPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.security.auth.AuthPermission.staticClass, global::javax.security.auth.AuthPermission._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AuthPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.security.auth.AuthPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/security/auth/AuthPermission"));
		}
	}
}
