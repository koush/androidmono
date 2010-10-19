namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RuntimePermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RuntimePermission()
		{
			InitJNI();
		}
		internal RuntimePermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _RuntimePermission14825;
		public RuntimePermission(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimePermission.staticClass, global::java.lang.RuntimePermission._RuntimePermission14825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _RuntimePermission14826;
		public RuntimePermission(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.RuntimePermission.staticClass, global::java.lang.RuntimePermission._RuntimePermission14826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.RuntimePermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/RuntimePermission"));
			global::java.lang.RuntimePermission._RuntimePermission14825 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimePermission.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.lang.RuntimePermission._RuntimePermission14826 = @__env.GetMethodIDNoThrow(global::java.lang.RuntimePermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
