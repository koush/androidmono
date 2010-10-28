namespace dalvik.system
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StaleDexCacheError : java.lang.VirtualMachineError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StaleDexCacheError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _StaleDexCacheError18607;
		public StaleDexCacheError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.StaleDexCacheError.staticClass, global::dalvik.system.StaleDexCacheError._StaleDexCacheError18607);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StaleDexCacheError18608;
		public StaleDexCacheError(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(dalvik.system.StaleDexCacheError.staticClass, global::dalvik.system.StaleDexCacheError._StaleDexCacheError18608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static StaleDexCacheError()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.system.StaleDexCacheError.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/system/StaleDexCacheError"));
			global::dalvik.system.StaleDexCacheError._StaleDexCacheError18607 = @__env.GetMethodIDNoThrow(global::dalvik.system.StaleDexCacheError.staticClass, "<init>", "()V");
			global::dalvik.system.StaleDexCacheError._StaleDexCacheError18608 = @__env.GetMethodIDNoThrow(global::dalvik.system.StaleDexCacheError.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
