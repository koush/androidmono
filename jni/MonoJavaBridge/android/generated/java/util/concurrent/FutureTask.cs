namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FutureTask : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static FutureTask()
		{
			InitJNI();
		}
		protected FutureTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run21358;
		public virtual void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._run21358);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._run21358);
		}
		internal static global::MonoJavaBridge.MethodId _get21359;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._get21359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._get21359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get21360;
		public virtual global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._get21360)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._get21360)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set21361;
		protected virtual void set(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._set21361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._set21361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancel21362;
		public virtual bool cancel(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._cancel21362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._cancel21362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled21363;
		public virtual bool isCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._isCancelled21363);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._isCancelled21363);
		}
		internal static global::MonoJavaBridge.MethodId _isDone21364;
		public virtual bool isDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._isDone21364);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._isDone21364);
		}
		internal static global::MonoJavaBridge.MethodId _done21365;
		protected virtual void done() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._done21365);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._done21365);
		}
		internal static global::MonoJavaBridge.MethodId _setException21366;
		protected virtual void setException(java.lang.Throwable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._setException21366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._setException21366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _runAndReset21367;
		protected virtual bool runAndReset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask._runAndReset21367);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._runAndReset21367);
		}
		internal static global::MonoJavaBridge.MethodId _FutureTask21368;
		public FutureTask(java.util.concurrent.Callable arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._FutureTask21368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FutureTask21369;
		public FutureTask(java.lang.Runnable arg0, java.lang.Object arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.FutureTask.staticClass, global::java.util.concurrent.FutureTask._FutureTask21369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.FutureTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/FutureTask"));
			global::java.util.concurrent.FutureTask._run21358 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "run", "()V");
			global::java.util.concurrent.FutureTask._get21359 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.FutureTask._get21360 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "get", "()Ljava/lang/Object;");
			global::java.util.concurrent.FutureTask._set21361 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "set", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.FutureTask._cancel21362 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "cancel", "(Z)Z");
			global::java.util.concurrent.FutureTask._isCancelled21363 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "isCancelled", "()Z");
			global::java.util.concurrent.FutureTask._isDone21364 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "isDone", "()Z");
			global::java.util.concurrent.FutureTask._done21365 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "done", "()V");
			global::java.util.concurrent.FutureTask._setException21366 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "setException", "(Ljava/lang/Throwable;)V");
			global::java.util.concurrent.FutureTask._runAndReset21367 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "runAndReset", "()Z");
			global::java.util.concurrent.FutureTask._FutureTask21368 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "<init>", "(Ljava/util/concurrent/Callable;)V");
			global::java.util.concurrent.FutureTask._FutureTask21369 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.FutureTask.staticClass, "<init>", "(Ljava/lang/Runnable;Ljava/lang/Object;)V");
		}
	}
}
