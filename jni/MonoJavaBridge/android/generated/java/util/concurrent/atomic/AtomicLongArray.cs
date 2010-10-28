namespace java.util.concurrent.atomic
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AtomicLongArray : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AtomicLongArray()
		{
			InitJNI();
		}
		protected AtomicLongArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get27605;
		public virtual long get(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._get27605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._get27605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString27606;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._toString27606)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._toString27606)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length27607;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._length27607);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._length27607);
		}
		internal static global::MonoJavaBridge.MethodId _set27608;
		public virtual void set(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._set27608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._set27608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndAdd27609;
		public virtual long getAndAdd(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lazySet27610;
		public virtual void lazySet(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._lazySet27610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._lazySet27610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getAndSet27611;
		public virtual long getAndSet(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _compareAndSet27612;
		public virtual bool compareAndSet(int arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _weakCompareAndSet27613;
		public virtual bool weakCompareAndSet(int arg0, long arg1, long arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getAndIncrement27614;
		public virtual long getAndIncrement(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAndDecrement27615;
		public virtual long getAndDecrement(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _incrementAndGet27616;
		public virtual long incrementAndGet(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _decrementAndGet27617;
		public virtual long decrementAndGet(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAndGet27618;
		public virtual long addAndGet(int arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray27619;
		public AtomicLongArray(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AtomicLongArray27620;
		public AtomicLongArray(long[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.atomic.AtomicLongArray.staticClass, global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.atomic.AtomicLongArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/atomic/AtomicLongArray"));
			global::java.util.concurrent.atomic.AtomicLongArray._get27605 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "get", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._toString27606 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.concurrent.atomic.AtomicLongArray._length27607 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "length", "()I");
			global::java.util.concurrent.atomic.AtomicLongArray._set27608 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "set", "(IJ)V");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndAdd27609 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndAdd", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._lazySet27610 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "lazySet", "(IJ)V");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndSet27611 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndSet", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._compareAndSet27612 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "compareAndSet", "(IJJ)Z");
			global::java.util.concurrent.atomic.AtomicLongArray._weakCompareAndSet27613 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "weakCompareAndSet", "(IJJ)Z");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndIncrement27614 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndIncrement", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._getAndDecrement27615 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "getAndDecrement", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._incrementAndGet27616 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "incrementAndGet", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._decrementAndGet27617 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "decrementAndGet", "(I)J");
			global::java.util.concurrent.atomic.AtomicLongArray._addAndGet27618 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "addAndGet", "(IJ)J");
			global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27619 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "(I)V");
			global::java.util.concurrent.atomic.AtomicLongArray._AtomicLongArray27620 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.atomic.AtomicLongArray.staticClass, "<init>", "([J)V");
		}
	}
}
