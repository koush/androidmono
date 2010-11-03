namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class SecurityPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal SecurityPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SecurityPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecurityPermission._m0.native == global::System.IntPtr.Zero)
				global::java.security.SecurityPermission._m0 = @__env.GetMethodIDNoThrow(global::java.security.SecurityPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecurityPermission.staticClass, global::java.security.SecurityPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public SecurityPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.SecurityPermission._m1.native == global::System.IntPtr.Zero)
				global::java.security.SecurityPermission._m1 = @__env.GetMethodIDNoThrow(global::java.security.SecurityPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.SecurityPermission.staticClass, global::java.security.SecurityPermission._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static SecurityPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.SecurityPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/SecurityPermission"));
		}
	}
}
