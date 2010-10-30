namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PriorityBlockingQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PriorityBlockingQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27339;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._add27339.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._add27339 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._add27339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27340;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._put27340.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._put27340 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._put27340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27341;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._toString27341.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._toString27341 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toString27341) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear27342;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._clear27342.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._clear27342 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "clear", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._clear27342);
		}
		internal static global::MonoJavaBridge.MethodId _contains27343;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._contains27343.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._contains27343 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._contains27343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27344;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._size27344.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._size27344 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "size", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._size27344);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27345;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._toArray27345.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._toArray27345 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toArray27345) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27346;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._toArray27346.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._toArray27346 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toArray27346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27347;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._iterator27347.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._iterator27347 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._iterator27347) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27348;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._remove27348.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._remove27348 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._remove27348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27349;
		public override global::java.lang.Object poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._poll27349.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._poll27349 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._poll27349) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27350;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._poll27350.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._poll27350 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._poll27350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27351;
		public override global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._peek27351.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._peek27351 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._peek27351) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27352;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._offer27352.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._offer27352 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._offer27352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27353;
		public override bool offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._offer27353.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._offer27353 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._offer27353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator27354;
		public virtual global::java.util.Comparator comparator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._comparator27354.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._comparator27354 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "comparator", "()Ljava/util/Comparator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Comparator>(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._comparator27354) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _take27355;
		public virtual global::java.lang.Object take()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._take27355.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._take27355 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._take27355) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27356;
		public virtual int remainingCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity27356.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity27356 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "remainingCapacity", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity27356);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27357;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._drainTo27357.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._drainTo27357 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._drainTo27357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27358;
		public virtual int drainTo(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._drainTo27358.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._drainTo27358 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._drainTo27358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27359;
		public PriorityBlockingQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27359.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27359 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27359);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27360;
		public PriorityBlockingQueue(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27360.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27360 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27361;
		public PriorityBlockingQueue(int arg0, java.util.Comparator arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27361.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27361 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27362;
		public PriorityBlockingQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27362.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27362 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PriorityBlockingQueue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.PriorityBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/PriorityBlockingQueue"));
		}
		internal static void InitJNI()
		{
		}
	}
}
