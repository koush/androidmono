namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimerTask_))]
	public abstract partial class TimerTask : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TimerTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run26874;
		public abstract void run();
		internal static global::MonoJavaBridge.MethodId _cancel26875;
		public virtual bool cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimerTask._cancel26875.native == global::System.IntPtr.Zero)
				global::java.util.TimerTask._cancel26875 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "cancel", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.TimerTask.staticClass, global::java.util.TimerTask._cancel26875);
		}
		internal static global::MonoJavaBridge.MethodId _scheduledExecutionTime26876;
		public virtual long scheduledExecutionTime()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimerTask._scheduledExecutionTime26876.native == global::System.IntPtr.Zero)
				global::java.util.TimerTask._scheduledExecutionTime26876 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "scheduledExecutionTime", "()J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.TimerTask.staticClass, global::java.util.TimerTask._scheduledExecutionTime26876);
		}
		internal static global::MonoJavaBridge.MethodId _TimerTask26877;
		protected TimerTask() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimerTask._TimerTask26877.native == global::System.IntPtr.Zero)
				global::java.util.TimerTask._TimerTask26877 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimerTask.staticClass, global::java.util.TimerTask._TimerTask26877);
			Init(@__env, handle);
		}
		static TimerTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimerTask))]
	internal sealed partial class TimerTask_ : java.util.TimerTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TimerTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run26878;
		public override void run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.TimerTask_._run26878.native == global::System.IntPtr.Zero)
				global::java.util.TimerTask_._run26878 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask_.staticClass, "run", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimerTask_._run26878);
		}
		static TimerTask_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
		}
		internal static void InitJNI()
		{
		}
	}
}
