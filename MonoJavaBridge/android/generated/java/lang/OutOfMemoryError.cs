namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutOfMemoryError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutOfMemoryError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _OutOfMemoryError20379;
		public OutOfMemoryError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.OutOfMemoryError.staticClass, global::java.lang.OutOfMemoryError._OutOfMemoryError20379);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutOfMemoryError20380;
		public OutOfMemoryError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.OutOfMemoryError.staticClass, global::java.lang.OutOfMemoryError._OutOfMemoryError20380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static OutOfMemoryError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.OutOfMemoryError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/OutOfMemoryError"));
			global::java.lang.OutOfMemoryError._OutOfMemoryError20379 = @__env.GetMethodIDNoThrow(global::java.lang.OutOfMemoryError.staticClass, "<init>", "()V");
			global::java.lang.OutOfMemoryError._OutOfMemoryError20380 = @__env.GetMethodIDNoThrow(global::java.lang.OutOfMemoryError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
