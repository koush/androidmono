namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SynchronousQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SynchronousQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _put27432;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "put", "(Ljava/lang/Object;)V", ref global::java.util.concurrent.SynchronousQueue._put27432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear27433;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "clear", "()V", ref global::java.util.concurrent.SynchronousQueue._clear27433);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27434;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "isEmpty", "()Z", ref global::java.util.concurrent.SynchronousQueue._isEmpty27434);
		}
		internal static global::MonoJavaBridge.MethodId _contains27435;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.SynchronousQueue._contains27435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27436;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "size", "()I", ref global::java.util.concurrent.SynchronousQueue._size27436);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27437;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.SynchronousQueue.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.concurrent.SynchronousQueue._toArray27437) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27438;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.SynchronousQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.concurrent.SynchronousQueue._toArray27438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27439;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.SynchronousQueue.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.concurrent.SynchronousQueue._iterator27439) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27440;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.SynchronousQueue._remove27440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27441;
		public override bool containsAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "containsAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.SynchronousQueue._containsAll27441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27442;
		public override bool removeAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "removeAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.SynchronousQueue._removeAll27442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27443;
		public override bool retainAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "retainAll", "(Ljava/util/Collection;)Z", ref global::java.util.concurrent.SynchronousQueue._retainAll27443, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27444;
		public override global::java.lang.Object poll()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "poll", "()Ljava/lang/Object;", ref global::java.util.concurrent.SynchronousQueue._poll27444) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27445;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::java.util.concurrent.SynchronousQueue._poll27445, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27446;
		public override global::java.lang.Object peek()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "peek", "()Ljava/lang/Object;", ref global::java.util.concurrent.SynchronousQueue._peek27446) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27447;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z", ref global::java.util.concurrent.SynchronousQueue._offer27447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27448;
		public override bool offer(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "offer", "(Ljava/lang/Object;)Z", ref global::java.util.concurrent.SynchronousQueue._offer27448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take27449;
		public virtual global::java.lang.Object take()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "take", "()Ljava/lang/Object;", ref global::java.util.concurrent.SynchronousQueue._take27449) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27450;
		public virtual int remainingCapacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "remainingCapacity", "()I", ref global::java.util.concurrent.SynchronousQueue._remainingCapacity27450);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27451;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I", ref global::java.util.concurrent.SynchronousQueue._drainTo27451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27452;
		public virtual int drainTo(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.SynchronousQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I", ref global::java.util.concurrent.SynchronousQueue._drainTo27452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SynchronousQueue27453;
		public SynchronousQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.SynchronousQueue._SynchronousQueue27453.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.SynchronousQueue._SynchronousQueue27453 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._SynchronousQueue27453);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SynchronousQueue27454;
		public SynchronousQueue(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.SynchronousQueue._SynchronousQueue27454.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.SynchronousQueue._SynchronousQueue27454 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._SynchronousQueue27454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SynchronousQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.SynchronousQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/SynchronousQueue"));
		}
		internal static void InitJNI()
		{
		}
	}
}
