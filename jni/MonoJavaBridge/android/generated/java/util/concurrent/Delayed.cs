namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Delayed_))]
	public interface Delayed : java.lang.Comparable
	{
		long getDelay(java.util.concurrent.TimeUnit arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Delayed))]
	public sealed partial class Delayed_ : java.lang.Object, Delayed
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Delayed_()
		{
			InitJNI();
		}
		internal Delayed_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getDelay27133;
		 long java.util.concurrent.Delayed.getDelay(java.util.concurrent.TimeUnit arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.Delayed_._getDelay27133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.Delayed_.staticClass, global::java.util.concurrent.Delayed_._getDelay27133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo27134;
		 int java.lang.Comparable.compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.Delayed_._compareTo27134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.Delayed_.staticClass, global::java.util.concurrent.Delayed_._compareTo27134, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Delayed_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Delayed"));
			global::java.util.concurrent.Delayed_._getDelay27133 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Delayed_.staticClass, "getDelay", "(Ljava/util/concurrent/TimeUnit;)J");
			global::java.util.concurrent.Delayed_._compareTo27134 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Delayed_.staticClass, "compareTo", "(Ljava/lang/Object;)I");
		}
	}
}
