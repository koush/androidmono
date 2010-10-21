namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutOfMemoryError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static OutOfMemoryError()
		{
			InitJNI();
		}
		protected OutOfMemoryError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _OutOfMemoryError20261;
		public OutOfMemoryError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.OutOfMemoryError.staticClass, global::java.lang.OutOfMemoryError._OutOfMemoryError20261);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _OutOfMemoryError20262;
		public OutOfMemoryError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.OutOfMemoryError.staticClass, global::java.lang.OutOfMemoryError._OutOfMemoryError20262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.OutOfMemoryError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/OutOfMemoryError"));
			global::java.lang.OutOfMemoryError._OutOfMemoryError20261 = @__env.GetMethodIDNoThrow(global::java.lang.OutOfMemoryError.staticClass, "<init>", "()V");
			global::java.lang.OutOfMemoryError._OutOfMemoryError20262 = @__env.GetMethodIDNoThrow(global::java.lang.OutOfMemoryError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
