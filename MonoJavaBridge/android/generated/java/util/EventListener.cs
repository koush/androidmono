namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.EventListener_))]
	public partial interface EventListener  : global::MonoJavaBridge.IJavaObject 
	{
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.EventListener))]
	internal sealed partial class EventListener_ : java.lang.Object, EventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static EventListener_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventListener"));
		}
	}
}
