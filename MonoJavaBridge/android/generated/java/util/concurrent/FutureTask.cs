namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FutureTask : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FutureTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run27307;
		public virtual void run()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._run27307.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._run27307 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "run", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._run27307);
		}
		internal static global::MonoJavaBridge.MethodId _get27308;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._get27308.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._get27308 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._get27308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get27309;
		public virtual global::java.lang.Object get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._get27309.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._get27309 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "get", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._get27309) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set27310;
		protected virtual void set(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._set27310.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._set27310 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "set", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._set27310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel27311;
		public virtual bool cancel(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._cancel27311.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._cancel27311 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "cancel", "(Z)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._cancel27311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled27312;
		public virtual bool isCancelled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._isCancelled27312.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._isCancelled27312 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "isCancelled", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._isCancelled27312);
		}
		internal static global::MonoJavaBridge.MethodId _isDone27313;
		public virtual bool isDone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._isDone27313.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._isDone27313 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "isDone", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._isDone27313);
		}
		internal static global::MonoJavaBridge.MethodId _done27314;
		protected virtual void done()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._done27314.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._done27314 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "done", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._done27314);
		}
		protected new global::java.lang.Throwable Exception
		{
			set
			{
				setException(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setException27315;
		protected virtual void setException(java.lang.Throwable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._setException27315.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._setException27315 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "setException", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._setException27315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runAndReset27316;
		protected virtual bool runAndReset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._runAndReset27316.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._runAndReset27316 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "runAndReset", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._runAndReset27316);
		}
		internal static global::MonoJavaBridge.MethodId _FutureTask27317;
		public FutureTask(java.util.concurrent.Callable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._FutureTask27317.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._FutureTask27317 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "<init>", "(Ljava/util/concurrent/Callable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._FutureTask27317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FutureTask27318;
		public FutureTask(java.lang.Runnable arg0, java.lang.Object arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.FutureTask._FutureTask27318.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.FutureTask._FutureTask27318 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._FutureTask27318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static FutureTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.FutureTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/FutureTask"));
		}
		internal static void InitJNI()
		{
		}
	}
}
