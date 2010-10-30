namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AllocationLimitError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AllocationLimitError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public AllocationLimitError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.AllocationLimitError._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.AllocationLimitError._m0 = @__env.GetMethodIDNoThrow(global::dalvik.system.AllocationLimitError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.AllocationLimitError.staticClass, global::dalvik.system.AllocationLimitError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public AllocationLimitError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.AllocationLimitError._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.AllocationLimitError._m1 = @__env.GetMethodIDNoThrow(global::dalvik.system.AllocationLimitError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.AllocationLimitError.staticClass, global::dalvik.system.AllocationLimitError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AllocationLimitError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.AllocationLimitError.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/AllocationLimitError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
