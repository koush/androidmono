namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConcurrentLinkedQueue : java.util.AbstractQueue, Queue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConcurrentLinkedQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "size", "()I", ref global::java.util.concurrent.ConcurrentLinkedQueue._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._m4) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.ConcurrentLinkedQueue._m6) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._m8) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.concurrent.ConcurrentLinkedQueue._m9) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.ConcurrentLinkedQueue._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ConcurrentLinkedQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentLinkedQueue._m11.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentLinkedQueue._m11 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._m11);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public ConcurrentLinkedQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.ConcurrentLinkedQueue._m12.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.ConcurrentLinkedQueue._m12 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentLinkedQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ConcurrentLinkedQueue.staticClass, global::java.util.concurrent.ConcurrentLinkedQueue._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConcurrentLinkedQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentLinkedQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentLinkedQueue"));
		}
	}
}
