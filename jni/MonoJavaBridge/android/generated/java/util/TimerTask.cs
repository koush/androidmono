namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.TimerTask_))]
	public abstract partial class TimerTask : java.lang.Object, java.lang.Runnable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimerTask()
		{
			InitJNI();
		}
		protected TimerTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run26755;
		public abstract void run();
		internal static global::MonoJavaBridge.MethodId _cancel26756;
		public virtual bool cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.TimerTask._cancel26756);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.TimerTask.staticClass, global::java.util.TimerTask._cancel26756);
		}
		internal static global::MonoJavaBridge.MethodId _scheduledExecutionTime26757;
		public virtual long scheduledExecutionTime() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.TimerTask._scheduledExecutionTime26757);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.TimerTask.staticClass, global::java.util.TimerTask._scheduledExecutionTime26757);
		}
		internal static global::MonoJavaBridge.MethodId _TimerTask26758;
		protected TimerTask()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.TimerTask.staticClass, global::java.util.TimerTask._TimerTask26758);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
			global::java.util.TimerTask._run26755 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "run", "()V");
			global::java.util.TimerTask._cancel26756 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "cancel", "()Z");
			global::java.util.TimerTask._scheduledExecutionTime26757 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "scheduledExecutionTime", "()J");
			global::java.util.TimerTask._TimerTask26758 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.TimerTask))]
	public sealed partial class TimerTask_ : java.util.TimerTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TimerTask_()
		{
			InitJNI();
		}
		internal TimerTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run26759;
		public override void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.TimerTask_._run26759);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.TimerTask_.staticClass, global::java.util.TimerTask_._run26759);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.TimerTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/TimerTask"));
			global::java.util.TimerTask_._run26759 = @__env.GetMethodIDNoThrow(global::java.util.TimerTask_.staticClass, "run", "()V");
		}
	}
}
