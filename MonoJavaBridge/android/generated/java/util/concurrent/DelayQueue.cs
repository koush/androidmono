namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DelayQueue : java.util.AbstractQueue, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DelayQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.DelayQueue._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool add(java.util.concurrent.Delayed arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/util/concurrent/Delayed;)Z", ref global::java.util.concurrent.DelayQueue._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void put(java.util.concurrent.Delayed arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/util/concurrent/Delayed;)V", ref global::java.util.concurrent.DelayQueue._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.DelayQueue._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "clear", "()V", ref global::java.util.concurrent.DelayQueue._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "size", "()I", ref global::java.util.concurrent.DelayQueue._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.DelayQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.DelayQueue._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.DelayQueue.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.DelayQueue._m7) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.DelayQueue.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.DelayQueue._m8) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.DelayQueue._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.concurrent.DelayQueue._m10) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.DelayQueue._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.concurrent.DelayQueue._m12) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.DelayQueue._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.DelayQueue._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual bool offer(java.util.concurrent.Delayed arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;)Z", ref global::java.util.concurrent.DelayQueue._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool offer(java.util.concurrent.Delayed arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.DelayQueue._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.Object take()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "take", "()Ljava/lang/Object;", ref global::java.util.concurrent.DelayQueue._m17) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int remainingCapacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "remainingCapacity", "()I", ref global::java.util.concurrent.DelayQueue._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int drainTo(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I", ref global::java.util.concurrent.DelayQueue._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I", ref global::java.util.concurrent.DelayQueue._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public DelayQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.DelayQueue._m21.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.DelayQueue._m21 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._m21);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public DelayQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.DelayQueue._m22.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.DelayQueue._m22 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DelayQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.DelayQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/DelayQueue"));
		}
	}
}
