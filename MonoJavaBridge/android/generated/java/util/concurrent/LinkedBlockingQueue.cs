namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedBlockingQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LinkedBlockingQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.LinkedBlockingQueue._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.concurrent.LinkedBlockingQueue._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "clear", "()V", ref global::java.util.concurrent.LinkedBlockingQueue._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "size", "()I", ref global::java.util.concurrent.LinkedBlockingQueue._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.LinkedBlockingQueue._m4) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.LinkedBlockingQueue._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.LinkedBlockingQueue._m6) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.LinkedBlockingQueue._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.LinkedBlockingQueue._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.concurrent.LinkedBlockingQueue._m9) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.concurrent.LinkedBlockingQueue._m10) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.LinkedBlockingQueue._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.LinkedBlockingQueue._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.Object take()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "take", "()Ljava/lang/Object;", ref global::java.util.concurrent.LinkedBlockingQueue._m13) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int remainingCapacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "remainingCapacity", "()I", ref global::java.util.concurrent.LinkedBlockingQueue._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual int drainTo(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I", ref global::java.util.concurrent.LinkedBlockingQueue._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.LinkedBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I", ref global::java.util.concurrent.LinkedBlockingQueue._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public LinkedBlockingQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.LinkedBlockingQueue._m17.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.LinkedBlockingQueue._m17 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._m17);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public LinkedBlockingQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.LinkedBlockingQueue._m18.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.LinkedBlockingQueue._m18 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public LinkedBlockingQueue(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.LinkedBlockingQueue._m19.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.LinkedBlockingQueue._m19 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LinkedBlockingQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.LinkedBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/LinkedBlockingQueue"));
		}
	}
}
