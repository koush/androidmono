namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SynchronousQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SynchronousQueue()
		{
			InitJNI();
		}
		protected SynchronousQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _put21483;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._put21483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._put21483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear21484;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._clear21484);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._clear21484);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21485;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._isEmpty21485);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._isEmpty21485);
		}
		internal static global::MonoJavaBridge.MethodId _contains21486;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._contains21486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._contains21486, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21487;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._size21487);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._size21487);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21488;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._toArray21488)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._toArray21488)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21489;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._toArray21489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._toArray21489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21490;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._iterator21490)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._iterator21490)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21491;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._remove21491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._remove21491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll21492;
		public override bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._containsAll21492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._containsAll21492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll21493;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._removeAll21493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._removeAll21493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll21494;
		public override bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._retainAll21494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._retainAll21494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21495;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._poll21495)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._poll21495)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll21496;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._poll21496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._poll21496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21497;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._peek21497)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._peek21497)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21498;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._offer21498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._offer21498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer21499;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._offer21499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._offer21499, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take21500;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._take21500)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._take21500)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity21501;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._remainingCapacity21501);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._remainingCapacity21501);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21502;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._drainTo21502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._drainTo21502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21503;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._drainTo21503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._drainTo21503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SynchronousQueue21504;
		public SynchronousQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._SynchronousQueue21504);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SynchronousQueue21505;
		public SynchronousQueue(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._SynchronousQueue21505, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.SynchronousQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/SynchronousQueue"));
			global::java.util.concurrent.SynchronousQueue._put21483 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.SynchronousQueue._clear21484 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.SynchronousQueue._isEmpty21485 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.SynchronousQueue._contains21486 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.SynchronousQueue._size21487 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "size", "()I");
			global::java.util.concurrent.SynchronousQueue._toArray21488 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._toArray21489 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._iterator21490 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.SynchronousQueue._remove21491 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.SynchronousQueue._containsAll21492 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.SynchronousQueue._removeAll21493 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.SynchronousQueue._retainAll21494 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.SynchronousQueue._poll21495 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._poll21496 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._peek21497 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._offer21498 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.SynchronousQueue._offer21499 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.SynchronousQueue._take21500 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._remainingCapacity21501 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.SynchronousQueue._drainTo21502 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.SynchronousQueue._drainTo21503 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.SynchronousQueue._SynchronousQueue21504 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.SynchronousQueue._SynchronousQueue21505 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "<init>", "(Z)V");
		}
	}
}
