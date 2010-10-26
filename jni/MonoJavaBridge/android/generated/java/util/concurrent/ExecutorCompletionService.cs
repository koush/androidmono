namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ExecutorCompletionService : java.lang.Object, CompletionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExecutorCompletionService()
		{
			InitJNI();
		}
		protected ExecutorCompletionService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _poll27261;
		public virtual global::java.util.concurrent.Future poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._poll27261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._poll27261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _poll27262;
		public virtual global::java.util.concurrent.Future poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._poll27262)) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._poll27262)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27263;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._submit27263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._submit27263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27264;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._submit27264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._submit27264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _take27265;
		public virtual global::java.util.concurrent.Future take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._take27265)) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._take27265)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _ExecutorCompletionService27266;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExecutorCompletionService27267;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0, java.util.concurrent.BlockingQueue arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorCompletionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorCompletionService"));
			global::java.util.concurrent.ExecutorCompletionService._poll27261 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._poll27262 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "()Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._submit27263 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._submit27264 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._take27265 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "take", "()Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27266 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;)V");
			global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService27267 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V");
		}
	}
}
