namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Future_))]
	public partial interface Future  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object get();
		global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1);
		bool cancel(bool arg0);
		bool isCancelled();
		bool isDone();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Future))]
	internal sealed partial class Future_ : java.lang.Object, Future
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Future_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		global::java.lang.Object java.util.concurrent.Future.get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.Future_.staticClass, "get", "()Ljava/lang/Object;", ref global::java.util.concurrent.Future_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.Object java.util.concurrent.Future.get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.Future_.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.Future_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.util.concurrent.Future.cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Future_.staticClass, "cancel", "(Z)Z", ref global::java.util.concurrent.Future_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.util.concurrent.Future.isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Future_.staticClass, "isCancelled", "()Z", ref global::java.util.concurrent.Future_._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		bool java.util.concurrent.Future.isDone()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.Future_.staticClass, "isDone", "()Z", ref global::java.util.concurrent.Future_._m4);
		}
		static Future_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Future_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Future"));
		}
	}
}
