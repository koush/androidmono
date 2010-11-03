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
		internal ScheduledFuture_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		long java.util.concurrent.Delayed.getDelay(java.util.concurrent.TimeUnit arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J", ref global::java.util.concurrent.ScheduledFuture_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.lang.Comparable.compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.ScheduledFuture_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		global::java.lang.Object java.util.concurrent.Future.get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "get", "()Ljava/lang/Object;", ref global::java.util.concurrent.ScheduledFuture_._m2) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Object java.util.concurrent.Future.get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.ScheduledFuture_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.util.concurrent.Future.cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "cancel", "(Z)Z", ref global::java.util.concurrent.ScheduledFuture_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.util.concurrent.Future.isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "isCancelled", "()Z", ref global::java.util.concurrent.ScheduledFuture_._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.concurrent.Future.isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ScheduledFuture_.staticClass, "isDone", "()Z", ref global::java.util.concurrent.ScheduledFuture_._m6);
		}
		static ScheduledFuture_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ScheduledFuture_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ScheduledFuture"));
		}
	}
}
