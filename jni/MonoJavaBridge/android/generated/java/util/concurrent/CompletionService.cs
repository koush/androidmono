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
		internal static global::MonoJavaBridge.MethodId _poll27105;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_._poll27105)) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_.staticClass, global::java.util.concurrent.CompletionService_._poll27105)) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _poll27106;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_._poll27106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_.staticClass, global::java.util.concurrent.CompletionService_._poll27106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27107;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.submit(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_._submit27107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_.staticClass, global::java.util.concurrent.CompletionService_._submit27107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27108;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_._submit27108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_.staticClass, global::java.util.concurrent.CompletionService_._submit27108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _take27109;
		global::java.util.concurrent.Future java.util.concurrent.CompletionService.take()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_._take27109)) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CompletionService_.staticClass, global::java.util.concurrent.CompletionService_._take27109)) as java.util.concurrent.Future;
		}
		static CompletionService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CompletionService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CompletionService"));
			global::java.util.concurrent.CompletionService_._poll27105 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CompletionService_.staticClass, "poll", "()Ljava/util/concurrent/Future;");
			global::java.util.concurrent.CompletionService_._poll27106 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CompletionService_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.CompletionService_._submit27107 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CompletionService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.CompletionService_._submit27108 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CompletionService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.CompletionService_._take27109 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CompletionService_.staticClass, "take", "()Ljava/util/concurrent/Future;");
		}
		internal static void InitJNI()
		{
		}
	}
}
