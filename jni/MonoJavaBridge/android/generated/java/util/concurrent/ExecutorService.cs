namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ExecutorService_))]
	public partial interface ExecutorService : Executor
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
	internal sealed partial class ExecutorService_ : java.lang.Object, ExecutorService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ExecutorService_()
		{
			InitJNI();
		}
		internal ExecutorService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _shutdown27269;
		void java.util.concurrent.ExecutorService.shutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._shutdown27269);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._shutdown27269);
		}
		internal static global::MonoJavaBridge.MethodId _awaitTermination27270;
		bool java.util.concurrent.ExecutorService.awaitTermination(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._awaitTermination27270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._awaitTermination27270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _submit27271;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._submit27271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._submit27271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27272;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.util.concurrent.Callable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._submit27272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._submit27272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _submit27273;
		global::java.util.concurrent.Future java.util.concurrent.ExecutorService.submit(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._submit27273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.concurrent.Future>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._submit27273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.concurrent.Future;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27274;
		global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAny27274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAny27274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAny27275;
		global::java.lang.Object java.util.concurrent.ExecutorService.invokeAny(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAny27275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAny27275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27276;
		global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAll27276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAll27276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _invokeAll27277;
		global::java.util.List java.util.concurrent.ExecutorService.invokeAll(java.util.Collection arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._invokeAll27277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._invokeAll27277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _shutdownNow27278;
		global::java.util.List java.util.concurrent.ExecutorService.shutdownNow()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._shutdownNow27278)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._shutdownNow27278)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _isShutdown27279;
		bool java.util.concurrent.ExecutorService.isShutdown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._isShutdown27279);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._isShutdown27279);
		}
		internal static global::MonoJavaBridge.MethodId _isTerminated27280;
		bool java.util.concurrent.ExecutorService.isTerminated()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._isTerminated27280);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._isTerminated27280);
		}
		internal static global::MonoJavaBridge.MethodId _execute27281;
		void java.util.concurrent.Executor.execute(java.lang.Runnable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_._execute27281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ExecutorService_.staticClass, global::java.util.concurrent.ExecutorService_._execute27281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ExecutorService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ExecutorService"));
			global::java.util.concurrent.ExecutorService_._shutdown27269 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "shutdown", "()V");
			global::java.util.concurrent.ExecutorService_._awaitTermination27270 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ExecutorService_._submit27271 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorService_._submit27272 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorService_._submit27273 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			global::java.util.concurrent.ExecutorService_._invokeAny27274 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ExecutorService_._invokeAny27275 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAny", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.concurrent.ExecutorService_._invokeAll27276 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;)Ljava/util/List;");
			global::java.util.concurrent.ExecutorService_._invokeAll27277 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "invokeAll", "(Ljava/util/Collection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			global::java.util.concurrent.ExecutorService_._shutdownNow27278 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "shutdownNow", "()Ljava/util/List;");
			global::java.util.concurrent.ExecutorService_._isShutdown27279 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "isShutdown", "()Z");
			global::java.util.concurrent.ExecutorService_._isTerminated27280 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "isTerminated", "()Z");
			global::java.util.concurrent.ExecutorService_._execute27281 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ExecutorService_.staticClass, "execute", "(Ljava/lang/Runnable;)V");
		}
	}
}
