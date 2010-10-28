namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DelayQueue : java.util.AbstractQueue, BlockingQueue
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DelayQueue()
		{
			InitJNI();
		}
		protected DelayQueue(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27229;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._add27229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._add27229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add27230;
		public virtual bool add(java.util.concurrent.Delayed arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._add27230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._add27230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27231;
		public virtual void put(java.util.concurrent.Delayed arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._put27231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._put27231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _put27232;
		public virtual void put(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._put27232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._put27232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear27233;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._clear27233);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._clear27233);
		}
		internal static global::MonoJavaBridge.MethodId _size27234;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._size27234);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._size27234);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27235;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._toArray27235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._toArray27235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27236;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._toArray27236)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._toArray27236)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27237;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._iterator27237)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._iterator27237)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27238;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._remove27238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._remove27238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _poll27239;
		public override global::java.lang.Object poll()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._poll27239)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._poll27239)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _poll27240;
		public virtual global::java.lang.Object poll(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._poll27240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._poll27240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _peek27241;
		public override global::java.lang.Object peek()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._peek27241)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._peek27241)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _offer27242;
		public virtual bool offer(java.lang.Object arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _offer27243;
		public override bool offer(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer27244;
		public virtual bool offer(java.util.concurrent.Delayed arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _offer27245;
		public virtual bool offer(java.util.concurrent.Delayed arg0, long arg1, java.util.concurrent.TimeUnit arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._offer27245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._offer27245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _take27246;
		public virtual global::java.lang.Object take()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._take27246)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._take27246)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remainingCapacity27247;
		public virtual int remainingCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._remainingCapacity27247);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._remainingCapacity27247);
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27248;
		public virtual int drainTo(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._drainTo27248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._drainTo27248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drainTo27249;
		public virtual int drainTo(java.util.Collection arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue._drainTo27249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._drainTo27249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DelayQueue27250;
		public DelayQueue() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._DelayQueue27250);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DelayQueue27251;
		public DelayQueue(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.DelayQueue.staticClass, global::java.util.concurrent.DelayQueue._DelayQueue27251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.DelayQueue.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/DelayQueue"));
			global::java.util.concurrent.DelayQueue._add27229 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._add27230 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "add", "(Ljava/util/concurrent/Delayed;)Z");
			global::java.util.concurrent.DelayQueue._put27231 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/util/concurrent/Delayed;)V");
			global::java.util.concurrent.DelayQueue._put27232 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "put", "(Ljava/lang/Object;)V");
			global::java.util.concurrent.DelayQueue._clear27233 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "clear", "()V");
			global::java.util.concurrent.DelayQueue._size27234 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "size", "()I");
			global::java.util.concurrent.DelayQueue._toArray27235 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._toArray27236 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._iterator27237 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.DelayQueue._remove27238 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._poll27239 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "poll", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._poll27240 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "poll", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._peek27241 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "peek", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._offer27242 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.DelayQueue._offer27243 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.DelayQueue._offer27244 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;)Z");
			global::java.util.concurrent.DelayQueue._offer27245 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "offer", "(Ljava/util/concurrent/Delayed;JLjava/util/concurrent/TimeUnit;)Z");
			global::java.util.concurrent.DelayQueue._take27246 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "take", "()Ljava/lang/Object;");
			global::java.util.concurrent.DelayQueue._remainingCapacity27247 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "remainingCapacity", "()I");
			global::java.util.concurrent.DelayQueue._drainTo27248 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;)I");
			global::java.util.concurrent.DelayQueue._drainTo27249 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "drainTo", "(Ljava/util/Collection;I)I");
			global::java.util.concurrent.DelayQueue._DelayQueue27250 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "()V");
			global::java.util.concurrent.DelayQueue._DelayQueue27251 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.DelayQueue.staticClass, "<init>", "(Ljava/util/Collection;)V");
		}
	}
}
