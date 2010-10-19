namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ThreadDeath : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ThreadDeath()
		{
			InitJNI();
		}
		protected ThreadDeath(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ThreadDeath15233;
		public ThreadDeath()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.ThreadDeath.staticClass, global::java.lang.ThreadDeath._ThreadDeath15233);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.ThreadDeath.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/ThreadDeath"));
			global::java.lang.ThreadDeath._ThreadDeath15233 = @__env.GetMethodIDNoThrow(global::java.lang.ThreadDeath.staticClass, "<init>", "()V");
		}
	}
}
