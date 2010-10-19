namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.EventListenerProxy_))]
	public abstract partial class EventListenerProxy : java.lang.Object, EventListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EventListenerProxy()
		{
			InitJNI();
		}
		protected EventListenerProxy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getListener20234;
		public virtual global::java.util.EventListener getListener() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.EventListener>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EventListenerProxy._getListener20234)) as java.util.EventListener;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.EventListener>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EventListenerProxy.staticClass, global::java.util.EventListenerProxy._getListener20234)) as java.util.EventListener;
		}
		internal static global::MonoJavaBridge.MethodId _EventListenerProxy20235;
		public EventListenerProxy(java.util.EventListener arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.EventListenerProxy.staticClass, global::java.util.EventListenerProxy._EventListenerProxy20235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventListenerProxy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventListenerProxy"));
			global::java.util.EventListenerProxy._getListener20234 = @__env.GetMethodIDNoThrow(global::java.util.EventListenerProxy.staticClass, "getListener", "()Ljava/util/EventListener;");
			global::java.util.EventListenerProxy._EventListenerProxy20235 = @__env.GetMethodIDNoThrow(global::java.util.EventListenerProxy.staticClass, "<init>", "(Ljava/util/EventListener;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.EventListenerProxy))]
	public sealed partial class EventListenerProxy_ : java.util.EventListenerProxy
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EventListenerProxy_()
		{
			InitJNI();
		}
		internal EventListenerProxy_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EventListenerProxy_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EventListenerProxy"));
		}
	}
}
