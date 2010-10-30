namespace java.util.concurrent.locks
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.locks.Condition_))]
	public partial interface Condition  : global::MonoJavaBridge.IJavaObject 
	{
		void await();
		bool await(long arg0, java.util.concurrent.TimeUnit arg1);
		void signal();
		void signalAll();
		void awaitUninterruptibly();
		long awaitNanos(long arg0);
		bool awaitUntil(java.util.Date arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.locks.Condition))]
	internal sealed partial class Condition_ : java.lang.Object, Condition
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Condition_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.util.concurrent.locks.Condition.await()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "await", "()V", ref global::java.util.concurrent.locks.Condition_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		bool java.util.concurrent.locks.Condition.await(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.locks.Condition_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.util.concurrent.locks.Condition.signal()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "signal", "()V", ref global::java.util.concurrent.locks.Condition_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.util.concurrent.locks.Condition.signalAll()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "signalAll", "()V", ref global::java.util.concurrent.locks.Condition_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.util.concurrent.locks.Condition.awaitUninterruptibly()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "awaitUninterruptibly", "()V", ref global::java.util.concurrent.locks.Condition_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		long java.util.concurrent.locks.Condition.awaitNanos(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "awaitNanos", "(J)J", ref global::java.util.concurrent.locks.Condition_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.concurrent.locks.Condition.awaitUntil(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.locks.Condition_.staticClass, "awaitUntil", "(Ljava/util/Date;)Z", ref global::java.util.concurrent.locks.Condition_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Condition_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.Condition_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/Condition"));
		}
		internal static void InitJNI()
		{
		}
	}
}
