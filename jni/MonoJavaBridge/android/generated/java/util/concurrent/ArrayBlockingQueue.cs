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
		internal static global::MonoJavaBridge.MethodId _add27044;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._add27044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._add27044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27045;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._put27045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._put27045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27046;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toString27046)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toString27046)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear27047;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._clear27047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._clear27047);
		}
		internal static global::MonoJavaBridge.MethodId _contains27048;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._contains27048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._contains27048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27049;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._size27049);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._size27049);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27050;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toArray27050)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toArray27050)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27051;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toArray27051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toArray27051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27052;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._iterator27052)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._iterator27052)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27053;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._remove27053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._remove27053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27054;
		public override global::java.lang.Object poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._poll27054)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._poll27054)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27055;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._poll27055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._poll27055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27056;
		public override global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._peek27056)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._peek27056)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27057;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._offer27057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._offer27057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27058;
		public override bool offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._offer27058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._offer27058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take27059;
		public virtual global::java.lang.Object take()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._take27059)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._take27059)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27060;
		public virtual int remainingCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity27060);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity27060);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27061;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._drainTo27061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._drainTo27061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27062;
		public virtual int drainTo(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._drainTo27062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._drainTo27062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue27063;
		public ArrayBlockingQueue(int arg0, bool arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue27063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue27064;
		public ArrayBlockingQueue(int arg0, bool arg1, java.util.Collection arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue27064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue27065;
		public ArrayBlockingQueue(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue27065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ArrayBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ArrayBlockingQueue"));
			global::java.util.concurrent.ArrayBlockingQueue._add27044 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._put27045 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.ArrayBlockingQueue._toString27046 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.ArrayBlockingQueue._clear27047 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.ArrayBlockingQueue._contains27048 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._size27049 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.ArrayBlockingQueue._toArray27050 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._toArray27051 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._iterator27052 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.ArrayBlockingQueue._remove27053 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._poll27054 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._poll27055 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._peek27056 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._offer27057 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._offer27058 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._take27059 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity27060 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.ArrayBlockingQueue._drainTo27061 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.ArrayBlockingQueue._drainTo27062 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue27063 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(IZ)V");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue27064 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(IZLjava/util/Collection;)V");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue27065 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(I)V");
		}
	}
}
