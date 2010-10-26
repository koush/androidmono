namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PriorityBlockingQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PriorityBlockingQueue()
		{
			InitJNI();
		}
		protected PriorityBlockingQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27338;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._add27338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._add27338, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27339;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._put27339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._put27339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27340;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._toString27340)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toString27340)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear27341;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._clear27341);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._clear27341);
		}
		internal static global::MonoJavaBridge.MethodId _contains27342;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._contains27342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._contains27342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27343;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._size27343);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._size27343);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27344;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._toArray27344)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toArray27344)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27345;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._toArray27345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toArray27345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27346;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._iterator27346)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._iterator27346)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27347;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._remove27347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._remove27347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27348;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._poll27348)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._poll27348)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27349;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._poll27349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._poll27349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27350;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._peek27350)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._peek27350)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27351;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._offer27351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._offer27351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27352;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._offer27352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._offer27352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator27353;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._comparator27353)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._comparator27353)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _take27354;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._take27354)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._take27354)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27355;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity27355);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity27355);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27356;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._drainTo27356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._drainTo27356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27357;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._drainTo27357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._drainTo27357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27358;
		public PriorityBlockingQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27358);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27359;
		public PriorityBlockingQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27359, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27360;
		public PriorityBlockingQueue(int arg0, java.util.Comparator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27360, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue27361;
		public PriorityBlockingQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.PriorityBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/PriorityBlockingQueue"));
			global::java.util.concurrent.PriorityBlockingQueue._add27338 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._put27339 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.PriorityBlockingQueue._toString27340 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.PriorityBlockingQueue._clear27341 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.PriorityBlockingQueue._contains27342 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._size27343 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.PriorityBlockingQueue._toArray27344 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._toArray27345 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._iterator27346 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.PriorityBlockingQueue._remove27347 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._poll27348 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._poll27349 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._peek27350 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._offer27351 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._offer27352 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._comparator27353 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.concurrent.PriorityBlockingQueue._take27354 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity27355 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.PriorityBlockingQueue._drainTo27356 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.PriorityBlockingQueue._drainTo27357 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27358 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27359 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27360 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue27361 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
