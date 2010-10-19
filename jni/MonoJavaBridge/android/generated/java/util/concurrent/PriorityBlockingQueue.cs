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
		internal static global::MonoJavaBridge.MethodId _add21390;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._add21390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._add21390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put21391;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._put21391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._put21391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21392;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._toString21392)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toString21392)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear21393;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._clear21393);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._clear21393);
		}
		internal static global::MonoJavaBridge.MethodId _contains21394;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._contains21394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._contains21394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21395;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._size21395);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._size21395);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21396;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._toArray21396)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toArray21396)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21397;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._toArray21397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._toArray21397, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21398;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._iterator21398)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._iterator21398)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21399;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._remove21399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._remove21399, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21400;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._poll21400)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._poll21400)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll21401;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._poll21401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._poll21401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21402;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._peek21402)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._peek21402)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21403;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._offer21403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._offer21403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer21404;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._offer21404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._offer21404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _comparator21405;
		public virtual global::java.util.Comparator comparator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._comparator21405)) as java.util.Comparator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._comparator21405)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _take21406;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._take21406)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._take21406)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity21407;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity21407);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity21407);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21408;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._drainTo21408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._drainTo21408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21409;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue._drainTo21409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._drainTo21409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue21410;
		public PriorityBlockingQueue()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21410);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue21411;
		public PriorityBlockingQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue21412;
		public PriorityBlockingQueue(int arg0, java.util.Comparator arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PriorityBlockingQueue21413;
		public PriorityBlockingQueue(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.PriorityBlockingQueue.staticClass, global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.PriorityBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/PriorityBlockingQueue"));
			global::java.util.concurrent.PriorityBlockingQueue._add21390 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._put21391 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.PriorityBlockingQueue._toString21392 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.PriorityBlockingQueue._clear21393 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.PriorityBlockingQueue._contains21394 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._size21395 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.PriorityBlockingQueue._toArray21396 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._toArray21397 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._iterator21398 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.PriorityBlockingQueue._remove21399 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._poll21400 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._poll21401 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._peek21402 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._offer21403 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._offer21404 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.PriorityBlockingQueue._comparator21405 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "comparator", "()Ljava/util/Comparator;");
			global::java.util.concurrent.PriorityBlockingQueue._take21406 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.PriorityBlockingQueue._remainingCapacity21407 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.PriorityBlockingQueue._drainTo21408 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.PriorityBlockingQueue._drainTo21409 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21410 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21411 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21412 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(ILjava/util/Comparator;)V");
			global::java.util.concurrent.PriorityBlockingQueue._PriorityBlockingQueue21413 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.PriorityBlockingQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
