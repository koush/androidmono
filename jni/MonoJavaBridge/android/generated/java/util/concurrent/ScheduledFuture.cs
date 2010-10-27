namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ScheduledFuture_))]
	public partial interface ScheduledFuture : Delayed, Future
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ScheduledFuture))]
	internal sealed partial class ScheduledFuture_ : java.lang.Object, ScheduledFuture
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ScheduledFuture_()
		{
			InitJNI();
		}
		internal ScheduledFuture_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDelay27384;
		long java.util.concurrent.Delayed.getDelay(java.util.concurrent.TimeUnit arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._getDelay27384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._getDelay27384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo27385;
		int java.lang.Comparable.compareTo(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._compareTo27385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._compareTo27385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _get27386;
		global::java.lang.Object java.util.concurrent.Future.get()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._get27386)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._get27386)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get27387;
		global::java.lang.Object java.util.concurrent.Future.get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._get27387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._get27387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _cancel27388;
		bool java.util.concurrent.Future.cancel(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._cancel27388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._cancel27388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled27389;
		bool java.util.concurrent.Future.isCancelled()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._isCancelled27389);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._isCancelled27389);
		}
		internal static global::MonoJavaBridge.MethodId _isDone27390;
		bool java.util.concurrent.Future.isDone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_._isDone27390);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ScheduledFuture_.staticClass, global::java.util.concurrent.ScheduledFuture_._isDone27390);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledFuture_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledFuture"));
			global::java.util.concurrent.ScheduledFuture_._getDelay27384 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.ScheduledFuture_._compareTo27385 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::java.util.concurrent.ScheduledFuture_._get27386 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "get", "()Ljava/lang/Object;");
			global::java.util.concurrent.ScheduledFuture_._get27387 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ScheduledFuture_._cancel27388 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "cancel", "(Z)Z");
			global::java.util.concurrent.ScheduledFuture_._isCancelled27389 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "isCancelled", "()Z");
			global::java.util.concurrent.ScheduledFuture_._isDone27390 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ScheduledFuture_.staticClass, "isDone", "()Z");
		}
	}
}
