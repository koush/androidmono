namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Delayed_))]
	public partial interface Delayed : java.lang.Comparable
	{
		long getDelay(java.util.concurrent.TimeUnit arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Delayed))]
	internal sealed partial class Delayed_ : java.lang.Object, Delayed
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Delayed_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		long java.util.concurrent.Delayed.getDelay(java.util.concurrent.TimeUnit arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.concurrent.Delayed_.staticClass, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J", ref global::java.util.concurrent.Delayed_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		int java.lang.Comparable.compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.Delayed_.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.util.concurrent.Delayed_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Delayed_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Delayed_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Delayed"));
		}
	}
}
