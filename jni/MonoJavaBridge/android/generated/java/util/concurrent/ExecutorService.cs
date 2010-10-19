namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ExecutorService_))]
	public interface ExecutorService : Executor
	{
		void shutdown();
		bool awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1);
		global::java.util.concurrent.Future submit(java.lang.Runnable arg0, java.lang.Object arg1);
		global::java.util.concurrent.Future submit(java.util.concurrent.Callable arg0);
		global::java.util.concurrent.Future submit(java.lang.Runnable arg0);
		global::java.lang.Object invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.lang.Object invokeAny(java.util.Collection arg0);
		global::java.util.List invokeAll(java.util.Collection arg0);
		global::java.util.List invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		global::java.util.List shutdownNow();
		bool isShutdown();
		bool isTerminated();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ExecutorService))]
	public sealed partial class ExecutorService_ : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExecutorService_()
		{
			InitJNI();
		}
		internal ExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown21320;
		 void java.util.concurrent.ExecutorService.shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._shutdown21320);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._shutdown21320);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination21321;
		 bool java.util.concurrent.ExecutorService.awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._awaitTermination21321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._awaitTermination21321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _submit21322;
		 global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._submit21322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._submit21322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit21323;
		 global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.util.concurrent.Callable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._submit21323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._submit21323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit21324;
		 global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._submit21324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._submit21324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny21325;
		 global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAny21325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAny21325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny21326;
		 global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAny21326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAny21326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll21327;
		 global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAll21327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAll21327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll21328;
		 global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAll21328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAll21328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow21329;
		 global::java.util.List java.util.concurrent.ExecutorService.shutdownNow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._shutdownNow21329)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._shutdownNow21329)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown21330;
		 bool java.util.concurrent.ExecutorService.isShutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._isShutdown21330);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._isShutdown21330);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated21331;
		 bool java.util.concurrent.ExecutorService.isTerminated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._isTerminated21331);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._isTerminated21331);
		}
		internal static global::MonoJavaBridge.MethodId _execute21332;
		 void java.util.concurrent.Executor.execute(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._execute21332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._execute21332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorService"));
			global::java.util.concurrent.ExecutorService_._shutdown21320 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "shutdown", "()V");
			global::java.util.concurrent.ExecutorService_._awaitTermination21321 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ExecutorService_._submit21322 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorService_._submit21323 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorService_._submit21324 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorService_._invokeAny21325 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ExecutorService_._invokeAny21326 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.concurrent.ExecutorService_._invokeAll21327 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;");
			global::java.util.concurrent.ExecutorService_._invokeAll21328 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			global::java.util.concurrent.ExecutorService_._shutdownNow21329 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.ExecutorService_._isShutdown21330 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.ExecutorService_._isTerminated21331 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.ExecutorService_._execute21332 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V");
		}
	}
}
