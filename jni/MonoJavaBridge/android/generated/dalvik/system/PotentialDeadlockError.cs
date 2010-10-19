namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PotentialDeadlockError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PotentialDeadlockError()
		{
			InitJNI();
		}
		protected PotentialDeadlockError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PotentialDeadlockError13065;
		public PotentialDeadlockError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PotentialDeadlockError.staticClass, global::dalvik.system.PotentialDeadlockError._PotentialDeadlockError13065);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PotentialDeadlockError13066;
		public PotentialDeadlockError(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.PotentialDeadlockError.staticClass, global::dalvik.system.PotentialDeadlockError._PotentialDeadlockError13066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.PotentialDeadlockError.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/PotentialDeadlockError"));
			global::dalvik.system.PotentialDeadlockError._PotentialDeadlockError13065 = @__env.GetMethodIDNoThrow(global::dalvik.system.PotentialDeadlockError.staticClass, "<init>", "()V");
			global::dalvik.system.PotentialDeadlockError._PotentialDeadlockError13066 = @__env.GetMethodIDNoThrow(global::dalvik.system.PotentialDeadlockError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
