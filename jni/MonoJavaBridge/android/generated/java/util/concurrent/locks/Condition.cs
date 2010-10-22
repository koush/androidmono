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
	public sealed partial class Condition_ : java.lang.Object, Condition
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Condition_()
		{
			InitJNI();
		}
		internal Condition_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _await27613;
		 void java.util.concurrent.locks.Condition.await() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._await27613);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._await27613);
		}
		internal static global::MonoJavaBridge.MethodId _await27614;
		 bool java.util.concurrent.locks.Condition.await(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._await27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._await27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _signal27615;
		 void java.util.concurrent.locks.Condition.signal() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._signal27615);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._signal27615);
		}
		internal static global::MonoJavaBridge.MethodId _signalAll27616;
		 void java.util.concurrent.locks.Condition.signalAll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._signalAll27616);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._signalAll27616);
		}
		internal static global::MonoJavaBridge.MethodId _awaitUninterruptibly27617;
		 void java.util.concurrent.locks.Condition.awaitUninterruptibly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._awaitUninterruptibly27617);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._awaitUninterruptibly27617);
		}
		internal static global::MonoJavaBridge.MethodId _awaitNanos27618;
		 long java.util.concurrent.locks.Condition.awaitNanos(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._awaitNanos27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._awaitNanos27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _awaitUntil27619;
		 bool java.util.concurrent.locks.Condition.awaitUntil(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_._awaitUntil27619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.locks.Condition_.staticClass, global::java.util.concurrent.locks.Condition_._awaitUntil27619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.locks.Condition_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/locks/Condition"));
			global::java.util.concurrent.locks.Condition_._await27613 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "await", "()V");
			global::java.util.concurrent.locks.Condition_._await27614 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "await", "(JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.locks.Condition_._signal27615 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "signal", "()V");
			global::java.util.concurrent.locks.Condition_._signalAll27616 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "signalAll", "()V");
			global::java.util.concurrent.locks.Condition_._awaitUninterruptibly27617 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "awaitUninterruptibly", "()V");
			global::java.util.concurrent.locks.Condition_._awaitNanos27618 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "awaitNanos", "(J)J");
			global::java.util.concurrent.locks.Condition_._awaitUntil27619 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.locks.Condition_.staticClass, "awaitUntil", "(Ljava/util/Date;)Z");
		}
	}
}
