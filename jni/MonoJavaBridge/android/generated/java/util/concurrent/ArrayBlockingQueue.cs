namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayBlockingQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ArrayBlockingQueue()
		{
			InitJNI();
		}
		protected ArrayBlockingQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add21096;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._add21096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._add21096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put21097;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._put21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._put21097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21098;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toString21098)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toString21098)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear21099;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._clear21099);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._clear21099);
		}
		internal static global::MonoJavaBridge.MethodId _contains21100;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._contains21100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._contains21100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21101;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._size21101);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._size21101);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21102;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toArray21102)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toArray21102)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21103;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toArray21103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toArray21103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21104;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._iterator21104)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._iterator21104)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21105;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._remove21105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._remove21105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll21106;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._poll21106)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._poll21106)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll21107;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._poll21107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._poll21107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek21108;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._peek21108)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._peek21108)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer21109;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._offer21109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._offer21109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer21110;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._offer21110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._offer21110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take21111;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._take21111)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._take21111)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity21112;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity21112);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity21112);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21113;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._drainTo21113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._drainTo21113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo21114;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._drainTo21114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._drainTo21114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue21115;
		public ArrayBlockingQueue(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue21115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue21116;
		public ArrayBlockingQueue(int arg0, bool arg1, java.util.Collection arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue21116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue21117;
		public ArrayBlockingQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue21117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ArrayBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ArrayBlockingQueue"));
			global::java.util.concurrent.ArrayBlockingQueue._add21096 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._put21097 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.ArrayBlockingQueue._toString21098 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.ArrayBlockingQueue._clear21099 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.ArrayBlockingQueue._contains21100 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._size21101 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.ArrayBlockingQueue._toArray21102 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._toArray21103 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._iterator21104 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.ArrayBlockingQueue._remove21105 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._poll21106 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._poll21107 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._peek21108 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._offer21109 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._offer21110 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._take21111 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity21112 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.ArrayBlockingQueue._drainTo21113 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.ArrayBlockingQueue._drainTo21114 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue21115 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(IZ)V");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue21116 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(IZLjava/util/Collection;)V");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue21117 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(I)V");
		}
	}
}
