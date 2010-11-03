namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.BlockingQueue_))]
	public partial interface BlockingQueue : Queue
	{
		bool add(java.lang.Object arg0);
		void put(java.lang.Object arg0);
		bool contains(java.lang.Object arg0);
		bool remove(java.lang.Object arg0);
		global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1);
		bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2);
		bool offer(java.lang.Object arg0);
		global::java.lang.Object take();
		int remainingCapacity();
		int drainTo(java.util.Collection arg0);
		int drainTo(java.util.Collection arg0, int arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.BlockingQueue))]
	internal sealed partial class BlockingQueue_ : java.lang.Object, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BlockingQueue_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		bool java.util.concurrent.BlockingQueue.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.util.concurrent.BlockingQueue.put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "put", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.BlockingQueue_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.util.concurrent.BlockingQueue.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		bool java.util.concurrent.BlockingQueue.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		global::java.lang.Object java.util.concurrent.BlockingQueue.poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.BlockingQueue_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		bool java.util.concurrent.BlockingQueue.offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		global::java.lang.Object java.util.concurrent.BlockingQueue.take()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "take", "()Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m7) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		int java.util.concurrent.BlockingQueue.remainingCapacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "remainingCapacity", "()I", ref global::java.util.concurrent.BlockingQueue_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;)I", ref global::java.util.concurrent.BlockingQueue_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		int java.util.concurrent.BlockingQueue.drainTo(java.util.Collection arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "drainTo", "(Ljava/util/Collection;I)I", ref global::java.util.concurrent.BlockingQueue_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		bool java.util.Queue.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		global::java.lang.Object java.util.Queue.remove()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "()Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m12) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		global::java.lang.Object java.util.Queue.poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m13) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		global::java.lang.Object java.util.Queue.peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m14) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		global::java.lang.Object java.util.Queue.element()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "element", "()Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m15) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		bool java.util.Queue.offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		bool java.util.Collection.add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		bool java.util.Collection.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		int java.util.Collection.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "hashCode", "()I", ref global::java.util.concurrent.BlockingQueue_._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void java.util.Collection.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "clear", "()V", ref global::java.util.concurrent.BlockingQueue_._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		bool java.util.Collection.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.BlockingQueue_._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		bool java.util.Collection.contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		bool java.util.Collection.addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.BlockingQueue_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		int java.util.Collection.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "size", "()I", ref global::java.util.concurrent.BlockingQueue_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		global::java.lang.Object[] java.util.Collection.toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m26;
		global::java.lang.Object[] java.util.Collection.toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.BlockingQueue_.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.BlockingQueue_._m26) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m27;
		global::java.util.Iterator java.util.Collection.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.BlockingQueue_._m27) as java.util.Iterator;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		bool java.util.Collection.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.BlockingQueue_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		bool java.util.Collection.containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.BlockingQueue_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		bool java.util.Collection.removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.BlockingQueue_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		bool java.util.Collection.retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.BlockingQueue_.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.BlockingQueue_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(((global::java.lang.Iterable)this).iterator());
		}
		private static global::MonoJavaBridge.MethodId _m32;
		global::java.util.Iterator java.lang.Iterable.iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.BlockingQueue_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.BlockingQueue_._m32) as java.util.Iterator;
		}
		static BlockingQueue_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.BlockingQueue_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/BlockingQueue"));
		}
	}
}
