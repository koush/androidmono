namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.CompletionService_))]
	public partial interface CompletionService  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.util.concurrent.Future poll();
		global::java.util.concurrent.Future poll(long arg0, java.util.concurrent.TimeUnit arg1);
		global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0);
		global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1);
		global::java.util.concurrent.Future take();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.CompletionService))]
	internal sealed partial class CompletionService_ : java.lang.Object, CompletionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CompletionService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.CompletionService_.staticClass, "poll", "()Ljava/util/concurrent/Future;", ref global::java.util.concurrent.CompletionService_._m0) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.CompletionService_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.CompletionService_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.submit(java.util.concurrent.Callable arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.CompletionService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.CompletionService_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.CompletionService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;", ref global::java.util.concurrent.CompletionService_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.concurrent.Future;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.take()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.concurrent.Future>(this, global::java.util.concurrent.CompletionService_.staticClass, "take", "()Ljava/util/concurrent/Future;", ref global::java.util.concurrent.CompletionService_._m4) as java.util.concurrent.Future;
		}
		static CompletionService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CompletionService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CompletionService"));
		}
	}
}
