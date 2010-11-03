namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RuntimePermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RuntimePermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public RuntimePermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RuntimePermission._m0.native == global::System.IntPtr.Zero)
				global::java.lang.RuntimePermission._m0 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimePermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimePermission.staticClass, global::java.lang.RuntimePermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public RuntimePermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.RuntimePermission._m1.native == global::System.IntPtr.Zero)
				global::java.lang.RuntimePermission._m1 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimePermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimePermission.staticClass, global::java.lang.RuntimePermission._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static RuntimePermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RuntimePermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/RuntimePermission"));
		}
	}
}
