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
		internal static global::MonoJavaBridge.MethodId _add26926;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._add26926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._add26926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put26927;
		public virtual void put(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._put26927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._put26927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString26928;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toString26928)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toString26928)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear26929;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._clear26929);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._clear26929);
		}
		internal static global::MonoJavaBridge.MethodId _contains26930;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._contains26930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._contains26930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26931;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._size26931);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._size26931);
		}
		internal static global::MonoJavaBridge.MethodId _toArray26932;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toArray26932)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toArray26932)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray26933;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._toArray26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._toArray26933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26934;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._iterator26934)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._iterator26934)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26935;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._remove26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._remove26935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll26936;
		public override global::java.lang.Object poll() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._poll26936)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._poll26936)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll26937;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._poll26937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._poll26937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek26938;
		public override global::java.lang.Object peek() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._peek26938)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._peek26938)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer26939;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._offer26939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._offer26939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer26940;
		public override bool offer(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._offer26940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._offer26940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _take26941;
		public virtual global::java.lang.Object take() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._take26941)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._take26941)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity26942;
		public virtual int remainingCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity26942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity26942);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo26943;
		public virtual int drainTo(java.util.Collection arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._drainTo26943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._drainTo26943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo26944;
		public virtual int drainTo(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue._drainTo26944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._drainTo26944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue26945;
		public ArrayBlockingQueue(int arg0, bool arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue26945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue26946;
		public ArrayBlockingQueue(int arg0, bool arg1, java.util.Collection arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue26946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ArrayBlockingQueue26947;
		public ArrayBlockingQueue(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.ArrayBlockingQueue.staticClass, global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue26947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ArrayBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ArrayBlockingQueue"));
			global::java.util.concurrent.ArrayBlockingQueue._add26926 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._put26927 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.ArrayBlockingQueue._toString26928 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.ArrayBlockingQueue._clear26929 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.ArrayBlockingQueue._contains26930 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._size26931 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.ArrayBlockingQueue._toArray26932 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._toArray26933 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._iterator26934 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.ArrayBlockingQueue._remove26935 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._poll26936 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._poll26937 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._peek26938 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._offer26939 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._offer26940 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ArrayBlockingQueue._take26941 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.ArrayBlockingQueue._remainingCapacity26942 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.ArrayBlockingQueue._drainTo26943 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.ArrayBlockingQueue._drainTo26944 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue26945 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(IZ)V");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue26946 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(IZLjava/util/Collection;)V");
			global::java.util.concurrent.ArrayBlockingQueue._ArrayBlockingQueue26947 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ArrayBlockingQueue.staticClass, "<init>", "(I)V");
		}
	}
}
