namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ReflectPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ReflectPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public ReflectPermission(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.ReflectPermission._m0.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.ReflectPermission._m0 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ReflectPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.ReflectPermission.staticClass, global::java.lang.reflect.ReflectPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public ReflectPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.ReflectPermission._m1.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.ReflectPermission._m1 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ReflectPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.ReflectPermission.staticClass, global::java.lang.reflect.ReflectPermission._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ReflectPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.ReflectPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/ReflectPermission"));
		}
	}
}
