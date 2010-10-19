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
		internal static global::MonoJavaBridge.MethodId _poll21313;
		public virtual global::java.util.concurrent.Future poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._poll21313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._poll21313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _poll21314;
		public virtual global::java.util.concurrent.Future poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._poll21314)) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._poll21314)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit21315;
		public virtual global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._submit21315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._submit21315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit21316;
		public virtual global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._submit21316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._submit21316, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _take21317;
		public virtual global::java.util.concurrent.Future take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService._take21317)) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._take21317)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _ExecutorCompletionService21318;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService21318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ExecutorCompletionService21319;
		public ExecutorCompletionService(java.util.concurrent.Executor arg0, java.util.concurrent.BlockingQueue arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ExecutorCompletionService.staticClass, global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService21319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorCompletionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorCompletionService"));
			global::java.util.concurrent.ExecutorCompletionService._poll21313 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._poll21314 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "poll", "()Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._submit21315 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._submit21316 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._take21317 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "take", "()Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService21318 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;)V");
			global::java.util.concurrent.ExecutorCompletionService._ExecutorCompletionService21319 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorCompletionService.staticClass, "<init>", "(Ljava/util/concurrent/Executor;Ljava/util/concurrent/BlockingQueue;)V");
		}
	}
}
