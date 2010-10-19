namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ReflectPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ReflectPermission()
		{
			InitJNI();
		}
		internal ReflectPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ReflectPermission15498;
		public ReflectPermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.ReflectPermission.staticClass, global::java.lang.reflect.ReflectPermission._ReflectPermission15498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ReflectPermission15499;
		public ReflectPermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.ReflectPermission.staticClass, global::java.lang.reflect.ReflectPermission._ReflectPermission15499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.ReflectPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/ReflectPermission"));
			global::java.lang.reflect.ReflectPermission._ReflectPermission15498 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ReflectPermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.reflect.ReflectPermission._ReflectPermission15499 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.ReflectPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
