namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.RejectedExecutionHandler_))]
	public interface RejectedExecutionHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.RejectedExecutionHandler))]
	public sealed partial class RejectedExecutionHandler_ : java.lang.Object, RejectedExecutionHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RejectedExecutionHandler_()
		{
			InitJNI();
		}
		internal RejectedExecutionHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _rejectedExecution27248;
		 void java.util.concurrent.RejectedExecutionHandler.rejectedExecution(java.lang.Runnable arg0, java.util.concurrent.ThreadPoolExecutor arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.RejectedExecutionHandler_._rejectedExecution27248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.RejectedExecutionHandler_.staticClass, global::java.util.concurrent.RejectedExecutionHandler_._rejectedExecution27248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.RejectedExecutionHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/RejectedExecutionHandler"));
			global::java.util.concurrent.RejectedExecutionHandler_._rejectedExecution27248 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.RejectedExecutionHandler_.staticClass, "rejectedExecution", "(Ljava/lang/Runnable;Ljava/util/concurrent/ThreadPoolExecutor;)V");
		}
	}
}
