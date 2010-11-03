namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FutureTask : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FutureTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void run()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, "run", "()V", ref global::java.util.concurrent.FutureTask._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.FutureTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.FutureTask._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.FutureTask.staticClass, "get", "()Ljava/lang/Object;", ref global::java.util.concurrent.FutureTask._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		protected virtual void set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, "set", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.FutureTask._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, "cancel", "(Z)Z", ref global::java.util.concurrent.FutureTask._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, "isCancelled", "()Z", ref global::java.util.concurrent.FutureTask._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual bool isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, "isDone", "()Z", ref global::java.util.concurrent.FutureTask._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void done()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, "done", "()V", ref global::java.util.concurrent.FutureTask._m7);
		}
		protected new global::java.lang.Throwable Exception
		{
			set
			{
				setException(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void setException(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, "setException", "(Ljava/lang/Throwable;)V", ref global::java.util.concurrent.FutureTask._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual bool runAndReset()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, "runAndReset", "()Z", ref global::java.util.concurrent.FutureTask._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public FutureTask(java.util.concurrent.Callable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._m10.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._m10 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "<init>", "(Ljava/util/concurrent/Callable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public FutureTask(java.lang.Runnable arg0, java.lang.Object arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._m11.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._m11 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FutureTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.FutureTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/FutureTask"));
		}
	}
}
