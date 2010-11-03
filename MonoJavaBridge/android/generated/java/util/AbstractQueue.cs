namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractQueue_))]
	public abstract partial class AbstractQueue : java.util.AbstractCollection, Queue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::java.lang.Object poll();
		private static global::MonoJavaBridge.MethodId _m1;
		public abstract global::java.lang.Object peek();
		private static global::MonoJavaBridge.MethodId _m2;
		public abstract bool offer(java.lang.Object arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractQueue.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractQueue._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.AbstractQueue.staticClass, "clear", "()V", ref global::java.util.AbstractQueue._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractQueue.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.AbstractQueue._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.Object remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractQueue.staticClass, "remove", "()Ljava/lang/Object;", ref global::java.util.AbstractQueue._m6) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.Object element()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractQueue.staticClass, "element", "()Ljava/lang/Object;", ref global::java.util.AbstractQueue._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected AbstractQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.AbstractQueue._m8.native == global::System.IntPtr.Zero)
				global::java.util.AbstractQueue._m8 = @__env.GetMethodIDNoThrow(global::java.util.AbstractQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractQueue.staticClass, global::java.util.AbstractQueue._m8);
			Init(@__env, handle);
		}
		static AbstractQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractQueue"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractQueue))]
	internal sealed partial class AbstractQueue_ : java.util.AbstractQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractQueue_.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.AbstractQueue_._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.AbstractQueue_.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.AbstractQueue_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.AbstractQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.AbstractQueue_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.AbstractQueue_.staticClass, "size", "()I", ref global::java.util.AbstractQueue_._m3);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.AbstractQueue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.AbstractQueue_._m4) as java.util.Iterator;
		}
		static AbstractQueue_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractQueue"));
		}
	}
}
