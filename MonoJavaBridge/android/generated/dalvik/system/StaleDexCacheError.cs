namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaleDexCacheError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StaleDexCacheError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public StaleDexCacheError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.StaleDexCacheError._m0.native == global::System.IntPtr.Zero)
				global::dalvik.system.StaleDexCacheError._m0 = @__env.GetMethodIDNoThrow(global::dalvik.system.StaleDexCacheError.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.StaleDexCacheError.staticClass, global::dalvik.system.StaleDexCacheError._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public StaleDexCacheError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.system.StaleDexCacheError._m1.native == global::System.IntPtr.Zero)
				global::dalvik.system.StaleDexCacheError._m1 = @__env.GetMethodIDNoThrow(global::dalvik.system.StaleDexCacheError.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.StaleDexCacheError.staticClass, global::dalvik.system.StaleDexCacheError._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StaleDexCacheError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.StaleDexCacheError.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/StaleDexCacheError"));
		}
		internal static void InitJNI()
		{
		}
	}
}
