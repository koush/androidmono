namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.EventListenerProxy_))]
	public abstract partial class EventListenerProxy : java.lang.Object, EventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EventListenerProxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getListener26173;
		public virtual global::java.util.EventListener getListener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.EventListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EventListenerProxy._getListener26173)) as java.util.EventListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.EventListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EventListenerProxy.staticClass, global::java.util.EventListenerProxy._getListener26173)) as java.util.EventListener;
		}
		internal static global::MonoJavaBridge.MethodId _EventListenerProxy26174;
		public EventListenerProxy(java.util.EventListener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EventListenerProxy.staticClass, global::java.util.EventListenerProxy._EventListenerProxy26174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static EventListenerProxy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventListenerProxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventListenerProxy"));
			global::java.util.EventListenerProxy._getListener26173 = @__env.GetMethodIDNoThrow(global::java.util.EventListenerProxy.staticClass, "getListener", "()Ljava/util/EventListener;");
			global::java.util.EventListenerProxy._EventListenerProxy26174 = @__env.GetMethodIDNoThrow(global::java.util.EventListenerProxy.staticClass, "<init>", "(Ljava/util/EventListener;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.EventListenerProxy))]
	internal sealed partial class EventListenerProxy_ : java.util.EventListenerProxy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EventListenerProxy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static EventListenerProxy_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventListenerProxy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventListenerProxy"));
		}
		internal static void InitJNI()
		{
		}
	}
}
