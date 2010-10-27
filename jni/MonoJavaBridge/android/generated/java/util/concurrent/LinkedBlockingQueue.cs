namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LinkedBlockingQueue : java.util.AbstractQueue, BlockingQueue, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LinkedBlockingQueue()
		{
			InitJNI();
		}
		protected LinkedBlockingQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _put27318;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._put27318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._put27318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27319;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._toString27319)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._toString27319)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clear27320;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._clear27320);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._clear27320);
		}
		internal static global::MonoJavaBridge.MethodId _size27321;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._size27321);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._size27321);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27322;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._toArray27322)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._toArray27322)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27323;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._toArray27323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._toArray27323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27324;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._iterator27324)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._iterator27324)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27325;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._remove27325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._remove27325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27326;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._poll27326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._poll27326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27327;
		public override global::java.lang.Object poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._poll27327)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._poll27327)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27328;
		public override global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._peek27328)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._peek27328)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27329;
		public override bool offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._offer27329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._offer27329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer27330;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._offer27330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._offer27330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _take27331;
		public virtual global::java.lang.Object take()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._take27331)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._take27331)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27332;
		public virtual int remainingCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._remainingCapacity27332);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._remainingCapacity27332);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27333;
		public virtual int drainTo(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._drainTo27333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._drainTo27333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27334;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue._drainTo27334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._drainTo27334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _LinkedBlockingQueue27335;
		public LinkedBlockingQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue27335);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedBlockingQueue27336;
		public LinkedBlockingQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue27336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LinkedBlockingQueue27337;
		public LinkedBlockingQueue(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.LinkedBlockingQueue.staticClass, global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue27337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.LinkedBlockingQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/LinkedBlockingQueue"));
			global::java.util.concurrent.LinkedBlockingQueue._put27318 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.LinkedBlockingQueue._toString27319 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.LinkedBlockingQueue._clear27320 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.LinkedBlockingQueue._size27321 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "size", "()I");
			global::java.util.concurrent.LinkedBlockingQueue._toArray27322 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._toArray27323 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._iterator27324 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.LinkedBlockingQueue._remove27325 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.LinkedBlockingQueue._poll27326 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._poll27327 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._peek27328 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._offer27329 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.LinkedBlockingQueue._offer27330 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.LinkedBlockingQueue._take27331 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.LinkedBlockingQueue._remainingCapacity27332 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.LinkedBlockingQueue._drainTo27333 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.LinkedBlockingQueue._drainTo27334 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue27335 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue27336 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.concurrent.LinkedBlockingQueue._LinkedBlockingQueue27337 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.LinkedBlockingQueue.staticClass, "<init>", "(I)V");
		}
	}
}
