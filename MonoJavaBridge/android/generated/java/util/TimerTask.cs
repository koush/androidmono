namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimerTask_))]
	public abstract partial class TimerTask : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimerTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void run();
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool cancel()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TimerTask.staticClass, "cancel", "()Z", ref global::java.util.TimerTask._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual long scheduledExecutionTime()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.TimerTask.staticClass, "scheduledExecutionTime", "()J", ref global::java.util.TimerTask._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected TimerTask() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimerTask._m3.native == global::System.IntPtr.Zero)
				global::java.util.TimerTask._m3 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimerTask.staticClass, global::java.util.TimerTask._m3);
			Init(@__env, handle);
		}
		static TimerTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimerTask))]
	internal sealed partial class TimerTask_ : java.util.TimerTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TimerTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.TimerTask_.staticClass, "run", "()V", ref global::java.util.TimerTask_._m0);
		}
		static TimerTask_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
		}
	}
}
