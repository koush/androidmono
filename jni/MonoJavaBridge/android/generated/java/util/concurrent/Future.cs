namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Future_))]
	public interface Future  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object get();
		global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1);
		bool cancel(bool arg0);
		bool isCancelled();
		bool isDone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Future))]
	public sealed partial class Future_ : java.lang.Object, Future
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Future_()
		{
			InitJNI();
		}
		internal Future_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21353;
		 global::java.lang.Object java.util.concurrent.Future.get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Future_._get21353)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Future_.staticClass, global::java.util.concurrent.Future_._get21353)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get21354;
		 global::java.lang.Object java.util.concurrent.Future.get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Future_._get21354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.Future_.staticClass, global::java.util.concurrent.Future_._get21354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _cancel21355;
		 bool java.util.concurrent.Future.cancel(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Future_._cancel21355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Future_.staticClass, global::java.util.concurrent.Future_._cancel21355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled21356;
		 bool java.util.concurrent.Future.isCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Future_._isCancelled21356);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Future_.staticClass, global::java.util.concurrent.Future_._isCancelled21356);
		}
		internal static global::MonoJavaBridge.MethodId _isDone21357;
		 bool java.util.concurrent.Future.isDone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.Future_._isDone21357);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.Future_.staticClass, global::java.util.concurrent.Future_._isDone21357);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Future_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Future"));
			global::java.util.concurrent.Future_._get21353 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Future_.staticClass, "get", "()Ljava/lang/Object;");
			global::java.util.concurrent.Future_._get21354 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Future_.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.Future_._cancel21355 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Future_.staticClass, "cancel", "(Z)Z");
			global::java.util.concurrent.Future_._isCancelled21356 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Future_.staticClass, "isCancelled", "()Z");
			global::java.util.concurrent.Future_._isDone21357 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Future_.staticClass, "isDone", "()Z");
		}
	}
}
