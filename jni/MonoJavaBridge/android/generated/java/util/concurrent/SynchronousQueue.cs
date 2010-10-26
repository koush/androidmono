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
		internal static global::MonoJavaBridge.MethodId _put27431;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._put27431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._put27431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear27432;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._clear27432);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._clear27432);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27433;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._isEmpty27433);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._isEmpty27433);
		}
		internal static global::MonoJavaBridge.MethodId _contains27434;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._contains27434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._contains27434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27435;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._size27435);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._size27435);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27436;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._toArray27436)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._toArray27436)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27437;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._toArray27437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._toArray27437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27438;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._iterator27438)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._iterator27438)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27439;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._remove27439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._remove27439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27440;
		public override bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._containsAll27440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._containsAll27440, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27441;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._removeAll27441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._removeAll27441, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27442;
		public override bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._retainAll27442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._retainAll27442, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27443;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._poll27443)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._poll27443)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27444;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._poll27444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._poll27444, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27445;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._peek27445)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._peek27445)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27446;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._offer27446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._offer27446, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27447;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._offer27447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._offer27447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take27448;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._take27448)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._take27448)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27449;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._remainingCapacity27449);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._remainingCapacity27449);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27450;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._drainTo27450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._drainTo27450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27451;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue._drainTo27451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._drainTo27451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SynchronousQueue27452;
		public SynchronousQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._SynchronousQueue27452);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SynchronousQueue27453;
		public SynchronousQueue(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.SynchronousQueue.staticClass, global::java.util.concurrent.SynchronousQueue._SynchronousQueue27453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.SynchronousQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/SynchronousQueue"));
			global::java.util.concurrent.SynchronousQueue._put27431 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.SynchronousQueue._clear27432 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.SynchronousQueue._isEmpty27433 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.SynchronousQueue._contains27434 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.SynchronousQueue._size27435 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "size", "()I");
			global::java.util.concurrent.SynchronousQueue._toArray27436 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._toArray27437 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._iterator27438 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.SynchronousQueue._remove27439 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.SynchronousQueue._containsAll27440 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.SynchronousQueue._removeAll27441 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.SynchronousQueue._retainAll27442 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.SynchronousQueue._poll27443 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._poll27444 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._peek27445 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._offer27446 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.SynchronousQueue._offer27447 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.SynchronousQueue._take27448 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.SynchronousQueue._remainingCapacity27449 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.SynchronousQueue._drainTo27450 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.SynchronousQueue._drainTo27451 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.SynchronousQueue._SynchronousQueue27452 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.SynchronousQueue._SynchronousQueue27453 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.SynchronousQueue.staticClass, "<init>", "(Z)V");
		}
	}
}
