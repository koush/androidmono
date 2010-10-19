namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AllocationLimitError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AllocationLimitError()
		{
			InitJNI();
		}
		protected AllocationLimitError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AllocationLimitError13042;
		public AllocationLimitError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.AllocationLimitError.staticClass, global::dalvik.system.AllocationLimitError._AllocationLimitError13042);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AllocationLimitError13043;
		public AllocationLimitError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.AllocationLimitError.staticClass, global::dalvik.system.AllocationLimitError._AllocationLimitError13043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.AllocationLimitError.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/AllocationLimitError"));
			global::dalvik.system.AllocationLimitError._AllocationLimitError13042 = @__env.GetMethodIDNoThrow(global::dalvik.system.AllocationLimitError.staticClass, "<init>", "()V");
			global::dalvik.system.AllocationLimitError._AllocationLimitError13043 = @__env.GetMethodIDNoThrow(global::dalvik.system.AllocationLimitError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
