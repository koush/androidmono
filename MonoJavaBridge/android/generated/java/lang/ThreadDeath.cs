namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadDeath : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ThreadDeath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ThreadDeath20874;
		public ThreadDeath() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.ThreadDeath._ThreadDeath20874.native == global::System.IntPtr.Zero)
				global::java.lang.ThreadDeath._ThreadDeath20874 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadDeath.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadDeath.staticClass, global::java.lang.ThreadDeath._ThreadDeath20874);
			Init(@__env, handle);
		}
		static ThreadDeath()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadDeath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadDeath"));
		}
		internal static void InitJNI()
		{
		}
	}
}
